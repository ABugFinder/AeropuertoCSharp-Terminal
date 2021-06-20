using System;
using System.Collections.Generic;
using System.Text;

namespace Aeropuerto
{
    public class Avion
    {
        /*private String nombre;
        private int numMotores;
        private int tipo;
        private double cargaTotal;*/
        public string Nombre { get; set; }
        public int NumMotores { get; set; }
        public int Tipo { get; set; }
        public double CargaTotal { get; set; }

        public Avion(String nombre, int numMotores, int tipo, double cargaTotal)
        {
            this.Nombre = nombre;
            this.NumMotores = numMotores;
            this.Tipo = tipo;
            this.CargaTotal = cargaTotal;
        }


    }
}
