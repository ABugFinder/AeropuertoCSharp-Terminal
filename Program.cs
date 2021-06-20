using System;
using System.Collections.Generic;

namespace Aeropuerto
{
    class Program
    {
        public static List<Ciudad>      ciudadesList    = new     List<Ciudad>();
        public static List<Avion>       avionesList     = new      List<Avion>();
        public static List<Aeropuerto>  aeropuertosList = new List<Aeropuerto>();

        public static void Main(string[] args)
        {
            /* Realizando registros para testing */
            Avion avion1 = new Avion("Avion-1-1-7", 6, 1, 2);
            Avion avion2 = new Avion("Avion-1-6", 2, 1, 0.5);
            Avion avion3 = new Avion("Avion-6-9", 4, 1, 1);
            Avion avion4 = new Avion("Avion-4-2-0", 4, 1, 1);
            Avion avion5 = new Avion("Avion-947", 12, 0, 6);

            Ciudad ciudad1 = new Ciudad("La Paz", "México");
            Ciudad ciudad2 = new Ciudad("Monterrey", "México");
            Ciudad ciudad3 = new Ciudad("CDMX", "México");
            Ciudad ciudad4 = new Ciudad("Buenos Aires", "Argentina");
            Ciudad ciudad5 = new Ciudad("Bogotá", "Colombia");
            RegistrarCiudad(ciudadesList, "Barcelona", "Madrid");

            Aeropuerto aeropuerto1 = new Aeropuerto("Aeropuerto Internacional de La Paz", ciudad1, 10, avionesList);
            Aeropuerto aeropuerto2 = new Aeropuerto("Aeropuerto Internacional de Monterrey", ciudad2, 50, avionesList);
            Aeropuerto aeropuerto3 = new Aeropuerto("Aeropuerto Internacional de CDMX", ciudad3, 100, avionesList);
            Aeropuerto aeropuerto4 = new Aeropuerto("Aeropuerto Internacional de Buenos Aires", ciudad4, 100, avionesList);
            Aeropuerto aeropuerto5 = new Aeropuerto("Aeropuerto Internacional de Bogotá", ciudad5, 100, avionesList);

            RegistrarCiudadExistente(ciudadesList, ciudad1);
            RegistrarCiudadExistente(ciudadesList, ciudad2);
            RegistrarCiudadExistente(ciudadesList, ciudad3);
            RegistrarCiudadExistente(ciudadesList, ciudad4);
            RegistrarCiudadExistente(ciudadesList, ciudad5);

            RegistrarAvionExistente(avionesList, avion1);
            RegistrarAvionExistente(avionesList, avion2);
            RegistrarAvionExistente(avionesList, avion3);
            RegistrarAvionExistente(avionesList, avion4);
            RegistrarAvionExistente(avionesList, avion5);

            RegistrarAeropuertoExistente(aeropuertosList, aeropuerto1);
            RegistrarAeropuertoExistente(aeropuertosList, aeropuerto2);
            RegistrarAeropuertoExistente(aeropuertosList, aeropuerto3);
            RegistrarAeropuertoExistente(aeropuertosList, aeropuerto4);
            RegistrarAeropuertoExistente(aeropuertosList, aeropuerto5);

            /* Termina zona de registro de pruebas*/

            /* Inicia menú con lógica del sistema de registros y consultas del aeropuerto */
            bool isActivo = true;
            while (isActivo)
            {
                Console.WriteLine("Selecciona una opción\n\n1 = registrar\n2 = consultar\n3 = salir");
                string input = Console.ReadLine();
                int numero = 10;
                if (int.TryParse(input, out numero)) // Validando si el input del usuario es número o no
                {
                    int res = Convert.ToInt32(input);
                    Console.Clear();
                    if (res == 1)
                    {
                        Console.WriteLine("Resgistros - selecciona:\n1-> Ciudades\n2-> Aviones\n3-> Aeropuertos");
                        input = Console.ReadLine();
                        if (int.TryParse(input, out numero))
                        {
                            res = Convert.ToInt32(input);
                            Console.Clear();
                            if (res == 1)
                            {
                                Console.WriteLine("Ingresa el nombre de la ciudad: ");
                                string nombre = Console.ReadLine();
                                Console.WriteLine("Ingresa el país de la ciudad: ");
                                string pais = Console.ReadLine();

                                RegistrarCiudad(ciudadesList, nombre, pais);
                            }
                            else if (res == 2)
                            {
                                Console.WriteLine("Ingresa el nombre del avion: ");
                                string nombre = Console.ReadLine();
                                Console.WriteLine("Ingresa el número de motores: ");
                                int numMotores = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Ingresa el tipo de avión: ");
                                int tipo = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Ingresa la garga máxima del avión: ");
                                double carga = Convert.ToDouble(Console.ReadLine());

                                RegistrarAvion(avionesList, nombre, numMotores, tipo, carga);
                            }
                            else if (res == 3)
                            {
                                Console.WriteLine("Ingresa el nombre del aeropuerto: ");
                                string nombre = Console.ReadLine();
                                Console.WriteLine("Ingresa la ciudad: ");
                                int cNum = Convert.ToInt32(Console.ReadLine());
                                Ciudad ciudad = ciudadesList[cNum];
                                Console.WriteLine("Ingresa el múmero de espcaios máximos de aviones del aeropuerto: ");
                                int espDisp = Convert.ToInt32(Console.ReadLine());

                                RegistrarAeropuerto(aeropuertosList, nombre, ciudad, espDisp);
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Resgistros - selecciona:\n1-> Ciudades\n2-> Aviones\n3-> Aeropuertos");
                        }
                    }
                    else if (res == 2)
                    {
                        Console.Clear();
                        MostrarCiudades(ciudadesList);
                        MostrarAviones(avionesList);
                        MostrarAeropuertos(aeropuertosList);
                    }
                    else if (res == 3)
                    {
                        isActivo = false;
                    }
                } else
                {
                    Console.Clear();
                    Console.WriteLine("Selecciona una opción\n\n1 = registrar\n2 = consultar\n3 = salir");
                }
                
            }

        }
        // Ojo aquí, señala el ejemplo de lo que pasa si no usas la lista como parámetro de la función, para explicar dicho error común
        // Esta función te permite crear un nuevo objeto del tipo ciudad y lo agrega a una lista de tipo Ciudad
        static void RegistrarCiudad(List<Ciudad> lista, string nombre, string pais)
        {
            Ciudad c = new Ciudad(nombre, pais);
            lista.Add(c);
        }
        // Esta función te permite agregar una ciudad que ya haya sido instanciada y la agrega en una lista del tipo Ciudad
        static void RegistrarCiudadExistente(List<Ciudad> lista, Ciudad c)
        {
            lista.Add(c);
        }
        // Esta función te permite crear un nuevo objeto del tipo Avion y lo agrega a una lista de tipo Avion
        static void RegistrarAvion(List<Avion> lista, string nombre, int numMotores, int tipo, double cargaTotal)
        {
            Avion a = new Avion(nombre, numMotores, tipo, cargaTotal);
            lista.Add(a);
        }

        static void RegistrarAvionExistente(List<Avion> lista, Avion a)
        {
            lista.Add(a);
        }
        // Esta función te permite crear un nuevo objeto del tipo Aeropuerto y lo agrega a una lista de tipo Aeropuerto
        static void RegistrarAeropuerto(List<Aeropuerto> lista, string nombre, Ciudad ciudad, int espaciosDisp)
        {
            List<Avion> listaA = new List<Avion>();
            Aeropuerto a = new Aeropuerto(nombre, ciudad, espaciosDisp, listaA);
            lista.Add(a);
        }

        static void RegistrarAeropuertoExistente(List<Aeropuerto> lista, Aeropuerto a)
        {
            lista.Add(a);
        }
        // Esta función imprime la lista Ciudad con un foreah
        static void MostrarCiudades(List<Ciudad> lista)
        {
            Console.WriteLine("Aeropuertos");
            foreach (Ciudad ciudad in lista)
            {
                Console.WriteLine($"{ciudad.Nombre} {ciudad.Pais}");
            }
            Console.WriteLine("--------\n");
        }
        // Esta función imprime la lista Avion con un foreah
        static void MostrarAviones(List<Avion> lista)
        {
            Console.WriteLine("Aviones");
            foreach (Avion avion in lista)
            {
                Console.WriteLine($"{avion.Nombre}");
            }
            Console.WriteLine("--------\n");
        }
        // Esta función imprime la lista Aeropuerto con un foreah
        static void MostrarAeropuertos(List<Aeropuerto> lista)
        {
            Console.WriteLine("Aeropuertos");
            foreach (Aeropuerto aeropuerto in lista)
            {
                Console.WriteLine($"{aeropuerto.Nombre}, Ciudad: {aeropuerto.Ciudad.Nombre}");
            }
            Console.WriteLine("--------\n");
        }
    }
}
