using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace appSimulacion
{
    public partial class Simulación : Form
    {

        //Atributos de la clase
        Logica.clsLogica p1;
        double tiempo = 0;
        Bitmap barra;
        float angulo = 0;
        int x = 0;
        int xequilibrio;

        public Simulación()
        {
            InitializeComponent();
            this.tbConsulta.ReadOnly = true;

            //Inicializar los componentes con los valores por defecto (ejercicio 1, taller 2)
            tb_k.Text = 1850.ToString();
            tb_masa.Text = (0.6).ToString();
            tb_long.Text = 4.ToString();
            tb_CIx.Text = 0.5.ToString();
            tb_CIv.Text = 0.ToString();
            this.comboBox1.SelectedIndex = 0;
            this.panel1.Controls.Add(picResorte);
            this.picResorte.Controls.Add(picBarra);
            xequilibrio = this.picResorte.Height;
            barra = new Bitmap(this.picBarra.Image);

        }

        /// <summary>
        /// Mantiene los componentes en movimiento en la simulacion, se encarga de colocar
        /// en pantalla los valores obtenidos (x,v,a,Tiempo, etc).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblX.Text = p1.x(tiempo).ToString("0.####");
            this.lblV.Text = p1.v(tiempo).ToString("0.####");
            this.lblAceleracion.Text = p1.a(tiempo).ToString("0.####");
            this.lblTiempo.Text = "Tiempo = " + tiempo.ToString("0.####");

            this.picBarra.Image = rotateImage(barra, angulo);
            x = Convert.ToInt32(100 * Math.Sin(angulo * (Math.PI / 180)) / (0.5)) * (-1);
            picResorte.Height = (xequilibrio + (x));


            tiempo += (this.timer1.Interval * (0.001));
            angulo = (float)p1.theta(tiempo) * (float)(180 / Math.PI);

        }

        /// <summary>
        /// Se encarga de rotar la imagen de la barra, para que coincida con el movimiento esperado.
        /// </summary>
        /// <param name="rotateMe"></param>
        /// <param name="angle"></param>
        /// <returns></returns>
        private Bitmap rotateImage(Bitmap rotateMe, float angle)
        {
            Bitmap rotatedImage = new Bitmap(rotateMe.Width, rotateMe.Height);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform(rotateMe.Width / 2, rotateMe.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-rotateMe.Width / 2, -rotateMe.Height / 2);
                g.DrawImage(rotateMe, new Point(0, 0));
            }

            return rotatedImage;
        }

        /// <summary>
        /// Cuando se le da click en "STAR" recoge los datos que estan en las cajas de texto
        /// para procesarlos y realizar las correspondientes valoraciones para reaizar la simulacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btStart_Click(object sender, EventArgs e)
        {
            
            try
            {
                double K = double.Parse(tb_k.Text.Replace(".", ","));
                double masa = double.Parse(tb_masa.Text.Replace(".", ","));
                double Radio = double.Parse(tb_long.Text.Replace(".", ",")) / 2;

                if (masa <= 0 || Radio <=0 || K <= 0)
                {
                    MessageBox.Show("La masa, la longitud y la constante del resorte deben ser mayores que cero.");
                    return;
                }
                double desfase = 0;
                double Amplitud = 0;
                double posicion0 = 0;
                double velocidad0 = 0;

                if (this.comboBox1.Text == "Condiciones Iniciales")
                {
                    velocidad0 = double.Parse(tb_CIv.Text.Replace(".", ","));
                    posicion0 = double.Parse(tb_CIx.Text.Replace(".", ","));

                    if (!(posicion0 == 0 && velocidad0 == 0))
                    {
                        if (posicion0 == 0)
                        {
                            if (velocidad0 > 0)
                            {
                                desfase = 0;
                            }
                            else
                            {
                                desfase = Math.PI;
                            }
                            Amplitud = Math.Abs(velocidad0 / Math.Sqrt(3 * K / masa));
                        }
                        else
                        {
                            desfase = Math.PI / 2 - Math.Atan(velocidad0 / (Math.Sqrt(3 * K / masa) * posicion0));
                            if (posicion0 < 0)
                            {
                                desfase += Math.PI;
                            }
                            Amplitud = Math.Abs(posicion0 / Math.Sin(desfase));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las condiciones iniciales no pueden ser cero");
                        return;
                    }
                }
                else if (this.comboBox1.Text == "Valores Iniciales")
                {
                    Amplitud = double.Parse(tb_CIx.Text.Replace(".", ","));
                    desfase = double.Parse(tb_CIv.Text.Replace(".", ","));
                }



                //saber si el angulo es mayor a 15°
                if ((Amplitud / Radio) > Math.PI / 12)
                {
                    MessageBox.Show("Con los datos ingresados el angulo maximo seria mayor a 15°, por lo tanto no se comportara como un M.A.S \nEsto causado por " + this.comboBox1.Text);
                    return;
                }

                this.p1 = new Logica.clsLogica(K, masa, Amplitud, Radio, desfase);
                BloquearCasillas(true);
                try
                {
                    if (K < 2)
                    {
                        Logica.clsLogica AuxP1 = new Logica.clsLogica(2, masa, Amplitud, Radio, desfase);
                        this.GraficarFunciones(AuxP1);
                    }
                    else
                    {
                        this.GraficarFunciones(p1);
                    }
                }
                catch (Exception)
                {
                }
               
                MostrarFuncion();
                this.label11.Text = " "+p1.getAmplitudInicial().ToString("0.##");
                this.label12.Text = "-"+p1.getAmplitudInicial().ToString("0.##");
                this.label13.Text = " " + p1.getVelocidadMax().ToString("0.##");
                this.label14.Text = "-"+p1.getVelocidadMax().ToString("0.##");
                this.label15.Text = " " + p1.getAceleracionMax().ToString("0.##");
                this.label16.Text = "-"+p1.getAceleracionMax().ToString("0.##");
                timer1.Start();

            }
            catch (Exception)
            {
                MessageBox.Show("Todos los campos deben llenarse con datos validos");
            }

        }

        /// <summary>
        /// Se encarga de bloquear o desbloquear las cajas de texto, dependiendo de la operacion que se este realizando
        /// </summary>
        /// <param name="mutex">True: bloquear // False: desbloquear </param>
        private void BloquearCasillas(Boolean mutex)
        {
            if (mutex == true)
            {
                this.tb_CIx.ReadOnly = true;
                this.tb_masa.ReadOnly = true;
                this.tb_k.ReadOnly = true;
                this.tb_CIv.ReadOnly = true;
                this.tb_long.ReadOnly = true;
                this.comboBox1.Enabled = false;
            }
            else
            {
                this.tb_CIx.ReadOnly = false;
                this.tb_masa.ReadOnly = false;
                this.tb_k.ReadOnly = false;
                this.tb_CIv.ReadOnly = false;
                this.tb_long.ReadOnly = false;
                this.comboBox1.Enabled = true;
            }
        }


        /// <summary>
        /// cuando se le da click a STOP se detiene la simulacion y se activan las cajas de texto, para modificarlas
        /// si se quiere.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSettings_Click(object sender, EventArgs e)
        {
            //habilitar para que se coloquen los datos
            this.BloquearCasillas(false);
            this.timer1.Stop();
            this.pictureBox3.Image = null;
            this.pictureBox2.Image = null;
            this.pictureBox4.Image = null;


            tiempo = 0;
            x = 0;
            angulo = 0;

        }

        /// <summary>
        /// Cuando se cambia la seleccion de la combo box, se calcula la opcion seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lbResultado.Text = "";
            this.tbConsulta.Text = "";
            if (this.cbConsulta.Text == "Periodo" || this.cbConsulta.Text == "Frecuencia" || this.cbConsulta.Text == "Frecuencia natural")
            {
                this.tbConsulta.ReadOnly = true;
                this.lbTConsulta.Visible = false;
                if (p1 != null)
                {
                    switch (this.cbConsulta.Text)
                    {
                        case "Periodo":
                            this.lbResultado.Text = p1.getPeriodo().ToString("0.####");
                            break;
                        case "Frecuencia":
                            this.lbResultado.Text = p1.getFrecuencia().ToString("0.####");
                            break;
                        case "Frecuencia natural":
                            this.lbResultado.Text = p1.getW().ToString("0.####");
                            break;
                        default:
                            break;
                    }

                }

            }
            else
            {
                this.lbTConsulta.Visible = true;
                this.tbConsulta.ReadOnly = false;
            }
        }

        /// <summary>
        /// cuando se modifica el texto en la caja de texto del tiempo, entonces como solo esta habilitada 
        /// en los que necesitan el tiempo pues los va calculando a medida que se va escribiendo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbConsulta_TextChanged(object sender, EventArgs e)
        {
            
            switch (this.cbConsulta.Text)
            {
                case "Posición en x":
                    try
                    {
                        this.lbResultado.Text = p1.x(double.Parse(this.tbConsulta.Text.Replace(".", ","))).ToString("0.####") + "m";
                    }
                    catch (Exception) { }
                    break;
                case "Velocidad":
                    try
                    {
                        this.lbResultado.Text = p1.v(double.Parse(this.tbConsulta.Text.Replace(".", ","))).ToString("0.####") + "m/s";
                    }
                    catch (Exception) { }
                    break;
                case "Aceleración":
                    try
                    {
                        this.lbResultado.Text = p1.a(double.Parse(this.tbConsulta.Text.Replace(".", ","))).ToString("0.####") + "m/s^2";
                    }
                    catch (Exception) { }
                    break;
                case "Posición angular":
                    try
                    {
                        this.lbResultado.Text = p1.theta(double.Parse(this.tbConsulta.Text.Replace(".", ","))).ToString("0.####");
                    }
                    catch (Exception) { }
                    break;
                case "Velocidad angular":
                    try
                    {
                        this.lbResultado.Text = p1.velocidadAngular(double.Parse(this.tbConsulta.Text.Replace(".", ","))).ToString("0.####");
                    }
                    catch (Exception) { }
                    break;

                case "Aceleración angular":
                    try
                    {
                        this.lbResultado.Text = p1.aceleracionAngular(double.Parse(this.tbConsulta.Text.Replace(".", ","))).ToString("0.####");
                    }
                    catch (Exception) { }
                    break;

                default:
                    break;
            }
        }

        private void MostrarFuncion()
        {

            lbFuncion.Text = "x(t) = " + p1.getAmplitudInicial().ToString("0.####") + " Sen ( " + p1.getW().ToString("0.####") + "t" + " + " + p1.getDesfase().ToString("0.####") + " )";

            lbFuncion.Visible = true;
        }

        /*
         picture box 3 = posicion
         picture box 2 = velocidad
         picture box 4 = aceleracion
             */
        //Declaraos lapices para dibujar las graficas
        System.Drawing.Pen LapizEjes = new System.Drawing.Pen(System.Drawing.Color.Black);
        System.Drawing.Pen LapizPosicion = new System.Drawing.Pen(System.Drawing.Color.Red);
        System.Drawing.Pen LapizVelocidad = new System.Drawing.Pen(System.Drawing.Color.Blue);
        System.Drawing.Pen LapizAceleracion = new System.Drawing.Pen(System.Drawing.Color.Green);

        //GRAFICAR EJES
        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            int xcentro = pictureBox3.Width / 2;
            int ycentro = pictureBox3.Height / 2;

            e.Graphics.TranslateTransform(xcentro, ycentro);
            e.Graphics.ScaleTransform(1, -1);

            //Graficamos EJES
            e.Graphics.DrawLine(LapizEjes, xcentro * -1, 0, xcentro * 2, 0);
            //e.Graphics.DrawLine(LapizEjes ,0, ycentro, 0, ycentro * -1);

        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {

            int xcentro = pictureBox2.Width / 2;
            int ycentro = pictureBox2.Height / 2;

            e.Graphics.TranslateTransform(xcentro, ycentro);
            e.Graphics.ScaleTransform(1, -1);

            //Graficamos EJES
            e.Graphics.DrawLine(LapizEjes, xcentro * -1, 0, xcentro * 2, 0);
            //e.Graphics.DrawLine(LapizEjes, 0, ycentro, 0, ycentro * -1);

        }

        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {

            int xcentro = pictureBox4.Width / 2;
            int ycentro = pictureBox4.Height / 2;

            e.Graphics.TranslateTransform(xcentro, ycentro);
            e.Graphics.ScaleTransform(1, -1);

            //Graficamos EJES
            e.Graphics.DrawLine(LapizEjes, xcentro * -1, 0, xcentro * 2, 0);
            //e.Graphics.DrawLine(LapizEjes, 0, ycentro, 0, ycentro * -1);

        }

        //LLAMADO A GRAFICAR FUNCIONES
        private void GraficarFunciones(Logica.clsLogica SimulacionObj)
        {
            this.GraficarPosicion(SimulacionObj);
            this.GraficarVelocidad(SimulacionObj);
            this.GraficarAceleracion(SimulacionObj);

        }

        //METODOS PARA GRAFICAR LAS FUNCIONES
        private void GraficarPosicion(Logica.clsLogica SimulacionObj)
        {

            System.Drawing.Graphics Posicion = this.pictureBox3.CreateGraphics();

            //Declaramos las variables y un arreglo
            double[] valores = new double[20000];
            double puntox1 = 0, puntoy1 = 0, puntox2 = 0, puntoy2 = 0;
            int con = 0;

            int xcentro = (pictureBox3.Width / 2) - 1;
            int ycentro = (pictureBox3.Height / 2) - 1;

            Posicion.TranslateTransform(0, ycentro);
            Posicion.ScaleTransform(1, -1);

            //ciclo for que genera los angulos de las funciones
            con = 0;
            for (double x = xcentro * -1; x < xcentro * 2; x += 0.1)
            {
                valores[con] = Math.Sin(x + SimulacionObj.getDesfase());
                con = con + 1;
            }

            con = 1;
            //ciclo for para poder sacar las coordenadas
            for (double xx = xcentro * -1 + 0.1; xx < xcentro * 2; xx += 0.1)
            {
                puntox1 = (xx - 0.1) * (pictureBox3.Width / (Convert.ToInt16(SimulacionObj.getFrecuencia()) * 2)); //mirar entre que se divide
                puntoy1 = valores[con - 1] * ycentro;

                puntox2 = xx * (pictureBox3.Width / (Convert.ToInt16(SimulacionObj.getFrecuencia()) * 2)); //mirar entre que se divide
                puntoy2 = valores[con] * ycentro;

                Posicion.DrawLine(LapizPosicion, Convert.ToSingle(puntox1), Convert.ToSingle(puntoy1), Convert.ToSingle(puntox2), Convert.ToSingle(puntoy2));
                con = con + 1;
            }
        }

        private void GraficarVelocidad(Logica.clsLogica SimulacionObj)
        {

            System.Drawing.Graphics Velocidad = this.pictureBox2.CreateGraphics();
            //Declaramos las variables y un arreglo
            double[] valores = new double[20000];
            double puntox1 = 0, puntoy1 = 0, puntox2 = 0, puntoy2 = 0;
            int con = 0;

            int xcentro = (pictureBox2.Width / 2) - 1;
            int ycentro = (pictureBox2.Height / 2) - 1;

            Velocidad.TranslateTransform(0, ycentro);
            Velocidad.ScaleTransform(1, -1);

            //ciclo for que genera los angulos de las funciones
            con = 0;
            for (double x = xcentro * -1; x < xcentro * 2; x += 0.1)
            {
                valores[con] = Math.Cos(x + SimulacionObj.getDesfase());
                con = con + 1;
            }

            con = 1;
            //ciclo for para poder sacar las coordenadas
            for (double xx = xcentro * -1 + 0.1; xx < xcentro * 2; xx += 0.1)
            {
                puntox1 = (xx - 0.1) * (pictureBox2.Width / (Convert.ToInt16(SimulacionObj.getFrecuencia()) * 2)); //mirar entre que se divide jaja
                puntoy1 = valores[con - 1] * ycentro;

                puntox2 = xx * (pictureBox2.Width / (Convert.ToInt16(SimulacionObj.getFrecuencia()) * 2)); //mirar entre que se divide jaja
                puntoy2 = valores[con] * ycentro;

                Velocidad.DrawLine(LapizPosicion, Convert.ToSingle(puntox1), Convert.ToSingle(puntoy1), Convert.ToSingle(puntox2), Convert.ToSingle(puntoy2));
                con = con + 1;
            }
        }

        private void GraficarAceleracion(Logica.clsLogica SimulacionObj)
        {

            System.Drawing.Graphics Aceleracion = this.pictureBox4.CreateGraphics();

            //Declaramos las variables y un arreglo
            double[] valores = new double[20000];
            double puntox1 = 0, puntoy1 = 0, puntox2 = 0, puntoy2 = 0;
            int con = 0;

            int xcentro = (pictureBox4.Width / 2) - 1;
            int ycentro = (pictureBox4.Height / 2) - 1;

            Aceleracion.TranslateTransform(0, ycentro);
            Aceleracion.ScaleTransform(1, -1);

            //ciclo for que genera los angulos de las funciones
            con = 0;
            for (double x = xcentro * -1; x < xcentro * 2; x += 0.1)
            {
                valores[con] = Math.Sin(x + Math.PI + SimulacionObj.getDesfase());
                con = con + 1;
            }

            con = 1;
            //ciclo for para poder sacar las coordenadas
            for (double xx = xcentro * -1 + 0.1; xx < xcentro * 2; xx += 0.1)
            {
                puntox1 = (xx - 0.1) * (pictureBox4.Width / (Convert.ToInt16(SimulacionObj.getFrecuencia()) * 2)); //mirar entre que se divide jaja
                puntoy1 = valores[con - 1] * ycentro;

                puntox2 = xx * (pictureBox4.Width / (Convert.ToInt16(SimulacionObj.getFrecuencia()) * 2)); //mirar entre que se divide jaja
                puntoy2 = valores[con] * ycentro;

                Aceleracion.DrawLine(LapizPosicion, Convert.ToSingle(puntox1), Convert.ToSingle(puntoy1), Convert.ToSingle(puntox2), Convert.ToSingle(puntoy2));
                con = con + 1;
            }
        }

        //SABER SI SE ELIGIERON CONDICIONES INICIALES O VALORES INICIALES
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBox1.Text)
            {
                case "Condiciones Iniciales":
                    try
                    {
                        this.lbTw.Text = "X(0):";
                        this.label3.Text = "V(0):";
                        this.tb_CIx.Text = "0,5";
                        this.tb_CIv.Text = "0";
                        this.lb_longitud.Show();
                        this.label1.Show();
                        this.label2.Show();
                        this.label3.Show();
                        this.lbTw.Show();
                        this.tb_long.Show();
                        this.tb_masa.Show();
                        this.tb_k.Show();
                        this.tb_CIx.Show();
                        this.tb_CIv.Show();
                        this.btStart.Show();
                        this.btSettings.Show();

                    }
                    catch (Exception) { }
                    break;
                case "Valores Iniciales":
                    try
                    {
                        this.lbTw.Text = "Amplitud:";
                        this.label3.Text = "Desface:";
                        this.tb_CIx.Text = "0,4";
                        this.tb_CIv.Text = "0";
                        this.lb_longitud.Show();
                        this.label1.Show();
                        this.label2.Show();
                        this.label3.Show();
                        this.lbTw.Show();
                        this.tb_long.Show();
                        this.tb_masa.Show();
                        this.tb_k.Show();
                        this.tb_CIx.Show();
                        this.tb_CIv.Show();
                        this.btStart.Show();
                        this.btSettings.Show();

                    }
                    catch (Exception) { }
                    break;


            }
        }
    }
}
