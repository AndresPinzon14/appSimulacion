namespace appSimulacion
{
    partial class Simulación
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simulación));
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbTw = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBarra = new System.Windows.Forms.PictureBox();
            this.picResorte = new System.Windows.Forms.PictureBox();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblAceleracion = new System.Windows.Forms.Label();
            this.lblV = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tb_masa = new System.Windows.Forms.TextBox();
            this.tb_k = new System.Windows.Forms.TextBox();
            this.tb_CIx = new System.Windows.Forms.TextBox();
            this.tb_CIv = new System.Windows.Forms.TextBox();
            this.btStart = new System.Windows.Forms.Button();
            this.btSettings = new System.Windows.Forms.Button();
            this.tb_long = new System.Windows.Forms.TextBox();
            this.lb_longitud = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbConsulta = new System.Windows.Forms.ComboBox();
            this.tbConsulta = new System.Windows.Forms.TextBox();
            this.lbResultado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTConsulta = new System.Windows.Forms.Label();
            this.lbFuncion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResorte)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(40, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(380, 22);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "Simulacion M.A.S Taller 2 Ejercicio 1";
            // 
            // lbTw
            // 
            this.lbTw.AutoSize = true;
            this.lbTw.Location = new System.Drawing.Point(93, 135);
            this.lbTw.Name = "lbTw";
            this.lbTw.Size = new System.Drawing.Size(29, 13);
            this.lbTw.TabIndex = 2;
            this.lbTw.Text = "X(0):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "masa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Constante k:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "V(0):";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.picBarra);
            this.panel1.Controls.Add(this.picResorte);
            this.panel1.Location = new System.Drawing.Point(44, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 272);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // picBarra
            // 
            this.picBarra.BackColor = System.Drawing.Color.Transparent;
            this.picBarra.Image = ((System.Drawing.Image)(resources.GetObject("picBarra.Image")));
            this.picBarra.Location = new System.Drawing.Point(-15, 5);
            this.picBarra.Name = "picBarra";
            this.picBarra.Size = new System.Drawing.Size(353, 297);
            this.picBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBarra.TabIndex = 14;
            this.picBarra.TabStop = false;
            // 
            // picResorte
            // 
            this.picResorte.BackColor = System.Drawing.Color.Transparent;
            this.picResorte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picResorte.Image = ((System.Drawing.Image)(resources.GetObject("picResorte.Image")));
            this.picResorte.Location = new System.Drawing.Point(15, 43);
            this.picResorte.Name = "picResorte";
            this.picResorte.Size = new System.Drawing.Size(400, 343);
            this.picResorte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResorte.TabIndex = 13;
            this.picResorte.TabStop = false;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(31, 16);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(42, 13);
            this.lblTiempo.TabIndex = 12;
            this.lblTiempo.Text = "Tiempo";
            // 
            // lblAceleracion
            // 
            this.lblAceleracion.AutoSize = true;
            this.lblAceleracion.Location = new System.Drawing.Point(72, 174);
            this.lblAceleracion.Name = "lblAceleracion";
            this.lblAceleracion.Size = new System.Drawing.Size(43, 13);
            this.lblAceleracion.TabIndex = 11;
            this.lblAceleracion.Text = "______";
            // 
            // lblV
            // 
            this.lblV.AutoSize = true;
            this.lblV.Location = new System.Drawing.Point(72, 110);
            this.lblV.Name = "lblV";
            this.lblV.Size = new System.Drawing.Size(43, 13);
            this.lblV.TabIndex = 10;
            this.lblV.Text = "______";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(72, 46);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(43, 13);
            this.lblX.TabIndex = 9;
            this.lblX.Text = "______";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "a =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "v =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "x =";
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tb_masa
            // 
            this.tb_masa.Location = new System.Drawing.Point(151, 80);
            this.tb_masa.Name = "tb_masa";
            this.tb_masa.Size = new System.Drawing.Size(158, 20);
            this.tb_masa.TabIndex = 16;
            // 
            // tb_k
            // 
            this.tb_k.Location = new System.Drawing.Point(151, 106);
            this.tb_k.Name = "tb_k";
            this.tb_k.Size = new System.Drawing.Size(158, 20);
            this.tb_k.TabIndex = 17;
            // 
            // tb_CIx
            // 
            this.tb_CIx.Location = new System.Drawing.Point(151, 132);
            this.tb_CIx.Name = "tb_CIx";
            this.tb_CIx.Size = new System.Drawing.Size(158, 20);
            this.tb_CIx.TabIndex = 18;
            // 
            // tb_CIv
            // 
            this.tb_CIv.Location = new System.Drawing.Point(151, 158);
            this.tb_CIv.Name = "tb_CIv";
            this.tb_CIv.Size = new System.Drawing.Size(158, 20);
            this.tb_CIv.TabIndex = 19;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(44, 447);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(398, 68);
            this.btStart.TabIndex = 20;
            this.btStart.Text = "START";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btSettings
            // 
            this.btSettings.Location = new System.Drawing.Point(468, 447);
            this.btSettings.Name = "btSettings";
            this.btSettings.Size = new System.Drawing.Size(426, 68);
            this.btSettings.TabIndex = 24;
            this.btSettings.Text = "STOP";
            this.btSettings.UseVisualStyleBackColor = true;
            this.btSettings.Click += new System.EventHandler(this.btSettings_Click);
            // 
            // tb_long
            // 
            this.tb_long.Location = new System.Drawing.Point(151, 54);
            this.tb_long.Name = "tb_long";
            this.tb_long.Size = new System.Drawing.Size(158, 20);
            this.tb_long.TabIndex = 15;
            // 
            // lb_longitud
            // 
            this.lb_longitud.AutoSize = true;
            this.lb_longitud.Location = new System.Drawing.Point(41, 57);
            this.lb_longitud.Name = "lb_longitud";
            this.lb_longitud.Size = new System.Drawing.Size(104, 13);
            this.lb_longitud.TabIndex = 26;
            this.lb_longitud.Text = "Longitud de la barra:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblX);
            this.groupBox1.Controls.Add(this.lblV);
            this.groupBox1.Controls.Add(this.lblAceleracion);
            this.groupBox1.Controls.Add(this.lblTiempo);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(468, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 230);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(130, 211);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 13);
            this.label16.TabIndex = 44;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(130, 165);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 13);
            this.label15.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(130, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(130, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(130, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(130, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 39;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(172, 165);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(254, 59);
            this.pictureBox4.TabIndex = 37;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox4_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(172, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(254, 59);
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox3_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(129, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Valores En Tiempo Real";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(172, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(254, 59);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.tb_k);
            this.groupBox2.Controls.Add(this.lbTw);
            this.groupBox2.Controls.Add(this.lb_longitud);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_long);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tb_masa);
            this.groupBox2.Controls.Add(this.tb_CIx);
            this.groupBox2.Controls.Add(this.tb_CIv);
            this.groupBox2.Location = new System.Drawing.Point(468, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 186);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(48, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "Tipo de Datos";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Condiciones Iniciales",
            "Valores Iniciales"});
            this.comboBox1.Location = new System.Drawing.Point(151, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 21);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbConsulta
            // 
            this.cbConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConsulta.FormattingEnabled = true;
            this.cbConsulta.Items.AddRange(new object[] {
            "Posición en x",
            "Velocidad",
            "Aceleración",
            "Posición angular",
            "Velocidad angular",
            "Aceleración angular",
            "Periodo",
            "Frecuencia",
            "Frecuencia natural"});
            this.cbConsulta.Location = new System.Drawing.Point(44, 343);
            this.cbConsulta.Name = "cbConsulta";
            this.cbConsulta.Size = new System.Drawing.Size(204, 28);
            this.cbConsulta.TabIndex = 29;
            this.cbConsulta.SelectedIndexChanged += new System.EventHandler(this.cbConsulta_SelectedIndexChanged);
            // 
            // tbConsulta
            // 
            this.tbConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConsulta.Location = new System.Drawing.Point(254, 345);
            this.tbConsulta.Name = "tbConsulta";
            this.tbConsulta.Size = new System.Drawing.Size(68, 26);
            this.tbConsulta.TabIndex = 30;
            this.tbConsulta.TextChanged += new System.EventHandler(this.tbConsulta_TextChanged);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(353, 347);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(0, 20);
            this.lbResultado.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 32;
            this.label4.Text = "Consulta";
            // 
            // lbTConsulta
            // 
            this.lbTConsulta.AutoSize = true;
            this.lbTConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTConsulta.Location = new System.Drawing.Point(250, 318);
            this.lbTConsulta.Name = "lbTConsulta";
            this.lbTConsulta.Size = new System.Drawing.Size(61, 20);
            this.lbTConsulta.TabIndex = 33;
            this.lbTConsulta.Text = "Tiempo";
            this.lbTConsulta.Visible = false;
            // 
            // lbFuncion
            // 
            this.lbFuncion.AutoSize = true;
            this.lbFuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFuncion.Location = new System.Drawing.Point(44, 391);
            this.lbFuncion.Name = "lbFuncion";
            this.lbFuncion.Size = new System.Drawing.Size(88, 20);
            this.lbFuncion.TabIndex = 34;
            this.lbFuncion.Text = "FUNCION";
            this.lbFuncion.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(616, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Datos Simulacion";
            // 
            // Simulación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(911, 548);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbFuncion);
            this.Controls.Add(this.lbTConsulta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.tbConsulta);
            this.Controls.Add(this.cbConsulta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btSettings);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTitulo);
            this.Name = "Simulación";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResorte)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbTw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblAceleracion;
        private System.Windows.Forms.Label lblV;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.PictureBox picResorte;
        private System.Windows.Forms.PictureBox picBarra;
        private System.Windows.Forms.PictureBox pictureBox1;
        //private System.Windows.Forms.Button START;
        //private System.Windows.Forms.Button SETTINGS;
        private System.Windows.Forms.TextBox tb_masa;
        private System.Windows.Forms.TextBox tb_k;
        private System.Windows.Forms.TextBox tb_CIx;
        private System.Windows.Forms.TextBox tb_CIv;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btSettings;
        private System.Windows.Forms.TextBox tb_long;
        private System.Windows.Forms.Label lb_longitud;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbConsulta;
        private System.Windows.Forms.TextBox tbConsulta;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTConsulta;
        private System.Windows.Forms.Label lbFuncion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}

