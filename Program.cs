using System;
using tp2Obligatorio.Model;

namespace tp2Obligatorio
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ArbolBinario nuevoarbol = new ArbolBinario();
            int inicio;
            string menu = null;

            Console.WriteLine("Ingrese un dato distinto de cero");
            do
            {
                inicio = Convert.ToInt32(Console.ReadLine()); //leo los datos ingresados
                if (inicio != 0)
                {
                    nuevoarbol.Agregar(Convert.ToInt32(inicio));
                    Console.WriteLine("Ingrese un dato o presione 0 para salir"); //los guardo
                }

            } while (inicio != 0);

            int mostrar_amp = nuevoarbol.Amplitud();

            Console.WriteLine("\n");

            do
            {
                /* Menu */
                Console.WriteLine("Seleccione:\nA-Mostrar PreOrden.\nB-Mostrar InOrden.\nC-Mostrar PostOrden.\nD-Eliminar Dato.\nE-Buscar Dato.\nF-Mostrar amplitud.\n0-Salir");
                menu = Console.ReadLine();
                Console.Clear();

                switch (menu)
                {
                    case "a":
                        Console.WriteLine("PreOrden:");
                        nuevoarbol.PreOrden(nuevoarbol.Raiz);
                        Console.WriteLine("\n");
                        break;

                    case "b":
                        Console.WriteLine("InOrden:");
                        nuevoarbol.InOrden(nuevoarbol.Raiz);
                        Console.WriteLine("\n");
                        break;

                    case "c":
                        Console.WriteLine("PostOrden:");
                        nuevoarbol.PostOrden(nuevoarbol.Raiz);
                        Console.WriteLine("\n\n");
                        break;

                    case "d":

                        /* Muestro los datos para que el usuario seleccione cual eliminar */
                        Console.WriteLine("PreOrden:");
                        nuevoarbol.PreOrden(nuevoarbol.Raiz);
                        Console.WriteLine("\n");

                        Console.WriteLine("InOrden:");
                        nuevoarbol.InOrden(nuevoarbol.Raiz);
                        Console.WriteLine("\n");

                        Console.WriteLine("PostOrden:");
                        nuevoarbol.PostOrden(nuevoarbol.Raiz);
                        Console.WriteLine("\n\n");

                        Console.WriteLine("Ingrese el valor a eliminar");
                        nuevoarbol.Eliminar(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("PreOrden luego de la operacion:");
                        nuevoarbol.PreOrden(nuevoarbol.Raiz);
                        Console.WriteLine();
                        break;

                    case "e":
                        Console.WriteLine("Ingrese el valor a buscar");
                        Nodo nodo = nuevoarbol.Buscar(Convert.ToInt32(Console.ReadLine()));
                        if (nodo == null)
                        {
                            Console.WriteLine("No se encontro el dato en el arbol");
                        }
                        else
                        {
                            Console.WriteLine(nodo);
                        }
                        break;

                    case "f":
                        Console.WriteLine(mostrar_amp);
                        break;

                    case "0":
                        menu = "0";
                        break;

                    default:
                        Console.WriteLine("Ingrese una opcion valida");
                        break;
                }

            } while (menu != "0");

            Console.ReadLine();
        }
    }
}