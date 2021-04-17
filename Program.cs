using System;

namespace primerparcial
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int opcionMenu = 0;
            int cantidad = 0;
            Cola nuevalista = new Cola();

            do
            {
                Console.WriteLine("\n");
                Console.WriteLine(" | --------------------------- | ");
                Console.WriteLine(" |  *Seleccione la operacion*  | ");
                Console.WriteLine(" | --------------------------- | ");
                Console.WriteLine(" | 1. Ingresar datos           | ");
                Console.WriteLine(" | 2. Buscar                   | ");
                Console.WriteLine(" | 3. Mostrar                  | ");
                Console.WriteLine(" | 4. Eliminar                 | ");
                Console.WriteLine(" | 5. Consultar                | ");
                Console.WriteLine(" | 6. Mostrar Primer Elemento  | ");
                Console.WriteLine(" | 7. Salir                    | ");
                Console.WriteLine(" | --------------------------- | ");
                Console.WriteLine("\n");
                opcionMenu = int.Parse(Console.ReadLine());

                switch (opcionMenu)
                {
                    case 1:
                        Console.WriteLine("Ingrese la cantidad de alumnos a colocar");
                        cantidad = int.Parse(Console.ReadLine());

                        Console.WriteLine("\n\nIngrese los datos del alumno\n");
                        for (int i = 0; i < cantidad; i++)
                        {
                            nuevalista.Insertarnodo();
                            Console.Clear();
                        }
                        break;
                    case 2:
                        Console.WriteLine("\n\nBuscar alumno\n");
                        nuevalista.BuscarAlumno();
                        break;
                    case 3:
                        nuevalista.Mostrarlista();
                        //c.modificarNodo();
                        break;
                    case 4:
                        Console.WriteLine("\n\n Eliminar alumno\n");
                        nuevalista.EliminarAlumno();
                        break;
                    case 5:
                        nuevalista.Consultar();
                        break;
                    case 6:
                        nuevalista.Peek();
                        break;
                    case 7:
                        Console.WriteLine("\n\n Programa Finalizado.... \n");
                        break;
                    default:
                        Console.WriteLine("\n\n Opcion No Valida.... \n");
                        break;
                }
            } while (opcionMenu != 7);


        }
    }
}