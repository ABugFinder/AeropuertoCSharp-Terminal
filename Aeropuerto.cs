using System;
using System.Collections.Generic;
using System.Text;

namespace Aeropuerto
{
    public class Aeropuerto
    {
        /*private String nombre;
        private Ciudad ciudad;
        private int espaciosDisp;
        private List<Avion> plazas;*/
        public String Nombre { get; set; }
        public Ciudad Ciudad { get; set; }
        public int EspaciosDisp { get; set; }
        public List<Avion> Plazas { get; set; }

        public Aeropuerto(String nombre, Ciudad ciudad, int espaciosDisp, List<Avion> plazas)
        {
            this.Nombre = nombre;
            this.Ciudad = ciudad;
            this.EspaciosDisp = espaciosDisp;
            this.Plazas = plazas;
        }



    }
}
