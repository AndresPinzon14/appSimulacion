using System;

namespace appSimulacion.Logica
{
    class clsLogica
    {
        #region Atributos
        /// <summary>
        /// Constante de elasticidad del resorte
        /// </summary>
        private double consK;
        /// <summary>
        /// Masa del cuerpo
        /// </summary>
        private double masa;
        /// <summary>
        /// Frecuencia natural del sistema
        /// </summary>
        private double w;
        /// <summary>
        /// Amplitud inicial del sistema
        /// </summary>
        private double amplitudMax;
        /// <summary>
        /// Desfase inicial del sistema
        /// </summary>
        private double desfase;

        private double periodo;

        private double frecuencia;

        private double radio;

        #endregion

        #region Getters y Setters
        public double getConsk()
        {
            return consK;
        }

        public double getMasa()
        {
            return masa;
        }

        public double getW()
        {
            return w;
        }

        public double getAmplitudInicial()
        {
            return amplitudMax;
        }

        public double getDesfase()
        {
            return desfase;
        }

        public double getPeriodo()
        {
            return periodo;
        }

        public double getFrecuencia()
        {
            return frecuencia;
        }

        public double getVelocidadMax()
        {
            return this.amplitudMax * this.w;
        }
        public double getAceleracionMax()
        {
            return this.amplitudMax * Math.Pow(this.w,2);
        }
        #endregion

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="parK">constante k</param>
        /// <param name="parMasa">masa de la barra</param>
        /// <param name="parAmplitud">Amplitud maxima</param>
        /// <param name="parRadio">Radio</param>
        /// <param name="parDesfase">Desfase del sistema</param>
        public clsLogica(double parK, double parMasa, double parAmplitud, double parRadio, double parDesfase)
        {
            consK = parK;
            masa = parMasa;
            w = Math.Sqrt(3 * consK / masa);
            periodo = 2 * Math.PI / w;
            frecuencia = 1 / periodo;
            amplitudMax = parAmplitud;
            radio = parRadio;
            desfase = parDesfase;
        }
        /// <summary>
        /// Retorna la posicion en x 
        /// </summary>
        /// <param name="t">Tiempo</param>
        /// <returns>Elongacion</returns>
        public double x(double t)
        {
            double posicion = 0;
            posicion = amplitudMax*Math.Sin(w*t + desfase);
            return posicion;
        }
        /// <summary>
        /// Retorna el valor de la velocidad
        /// </summary>
        /// <param name="t">Tiempo</param>
        /// <returns>Velocidad</returns>
        public double v(double t)
        {
            double velocidad = 0;
            velocidad = amplitudMax * w* Math.Cos((w * t) + desfase);
            return velocidad;
        }
        /// <summary>
        /// Retorna la aceleración
        /// </summary>
        /// <param name="t">Tiempo</param>
        /// <returns>Aceleracion.</returns>
        public double a(double t)
        {
            double aceleracion = 0;
            aceleracion = (-1)*amplitudMax *w*w* Math.Sin(w * t + desfase);
            return aceleracion;
        }

        /// <summary>
        /// Retorna el angulo
        /// </summary>
        /// <param name="t">Tiempo</param>
        /// <returns>Angulo Theta</returns>
        public double theta(double t)
        {
            return x(t)/radio;
        }

        /// <summary>
        /// Retorna la velocidad angular
        /// </summary>
        /// <param name="t">Tiempo</param>
        /// <returns>Velocidad Angular</returns>
        public double velocidadAngular(double t)
        {
            return v(t) / radio;
        }

        /// <summary>
        /// Retorna la Aceleracion Angular
        /// </summary>
        /// <param name="t">Tiempo</param>
        /// <returns>Aceleracion Angular</returns>
        public double aceleracionAngular(double t)
        {
            return a(t) / radio;
        }

    }
}
