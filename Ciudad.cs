using System;
using System.Collections.Generic;
using System.Text;

namespace Aeropuerto
{
    public class Ciudad
    {
        //private String nombre;
        //private String pais;
        public String Nombre { get; set; }
        public String Pais { get; set; }

        public Ciudad(String nombre, String pais)
        {
            this.Nombre = nombre;
            this.Pais = pais;
        }
        
        public void CambiarCiudad(string nombre, string pais)
        {
            this.Nombre = nombre;
            this.Pais = pais;
        }

    }
}
