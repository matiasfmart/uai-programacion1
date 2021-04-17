using System;
namespace primerparcial
{
    class Cola
    {
        private nodo_alumno Primero = new nodo_alumno();
        private nodo_alumno Ultimo = new nodo_alumno();

        public Cola()
        {
            Primero = null;
            Ultimo = null;
        }

        public void Insertarnodo()
        {
            nodo_alumno Nuevo = new nodo_alumno();

            /*Se ingresan los datos*/
            Console.WriteLine("\nNombre");
            Nuevo.Nombre = Console.ReadLine();
            Console.WriteLine("\nApellido");
            Nuevo.Apellido = Console.ReadLine();
            Console.WriteLine("\nFecha de nacimiento (DD/MM/AAAA)");
            Nuevo.FechaNac = Convert.ToDateTime(Console.ReadLine());

            /*Se reasignan las referencias para los nodos*/
            if (Primero == null)
            {
                Primero = Nuevo;
                Primero.Siguiente = null;
                Ultimo = Nuevo;
            }
            else
            {
                Ultimo.Siguiente = Nuevo;
                Nuevo.Siguiente = null;
                Ultimo = Nuevo;
            }
        }

        public void Mostrarlista()
        {
            nodo_alumno Buscador = new nodo_alumno();
            Buscador = Primero;

            if (Primero != null)
            {
                Console.WriteLine("Nombre  Apellido\tFecha de Nacimiento\n");
                while (Buscador != null)
                {
                    Console.WriteLine($"{Buscador.Nombre}\t {Buscador.Apellido}\t {Buscador.FechaNac.ToString("dd/MM/yyyy")}");
                    Buscador = Buscador.Siguiente; //Asigno el nodo al siguiente para mostrarlo
                }
            }
            else
            {
                Console.WriteLine("La lista esta vacia");
            }
        }

        public void BuscarAlumno()
        {
            nodo_alumno Buscador = new nodo_alumno();
            Buscador = Primero;
            nodo_alumno Alumnobuscado = new nodo_alumno();

            /*leo el apellido ingresado*/
            Console.WriteLine("Ingrese el apellido del alumno");
            Alumnobuscado.Apellido = Console.ReadLine();
            bool Encontrado = false;


            if (Primero != null)
            {
                Console.WriteLine("Nombre  Apellido\tFecha de Nacimiento\n");
                while (Buscador != null && Encontrado != true)
                {
                    if(Buscador.Apellido == Alumnobuscado.Apellido)
                    {
                        /*Muestro el alumno encontrado*/
                        Console.WriteLine($"{Buscador.Nombre}\t {Buscador.Apellido}\t {Buscador.FechaNac.ToString("dd/MM/yyyy")}");
                        Encontrado = true;
                    }
                    Buscador = Buscador.Siguiente;
                }
                if (!Encontrado)
                {
                    Console.WriteLine("El alumno no esta en la lista");
                }
            }
            else
            {
                Console.WriteLine("La lista esta vacia");
            }
        }

        public void EliminarAlumno()
        {
            nodo_alumno Buscador = new nodo_alumno();
            Buscador = Primero;
            bool Encontrado = false;
            nodo_alumno Alumnobuscado = new nodo_alumno();
            nodo_alumno Anterior = new nodo_alumno();
            Anterior = null;

            /*leo el apellido ingresado*/
            Console.WriteLine("Ingrese el apellido del alumno");    
            Alumnobuscado.Apellido = Console.ReadLine();



            if (Primero != null)
            {
                Console.WriteLine("Nombre  Apellido\tFecha de Nacimiento\n");
                while (Buscador != null && Encontrado != true)
                {
                    if (Buscador.Apellido == Alumnobuscado.Apellido)
                    {
                        /*Muestro el alumno encontrado*/
                        Console.WriteLine($"{Buscador.Nombre}\t {Buscador.Apellido}\t {Buscador.FechaNac.ToString("dd/MM/yyyy")}");

                        if (Buscador == Primero)
                        {
                            Primero = Primero.Siguiente;
                        }
                        else if (Buscador == Ultimo)
                        {
                            Anterior.Siguiente = null;
                            Ultimo = Anterior;
                        }
                        else
                        {
                            Anterior.Siguiente = Buscador.Siguiente;
                        }
                        Console.WriteLine("\nSe elimino el alumno\n");
                        Encontrado = true;
                    }
                    Anterior = Buscador;
                    Buscador = Buscador.Siguiente;
                }
                if (!Encontrado)
                {
                    Console.WriteLine("El alumno no esta en la lista");
                }
            }
            else
            {
                Console.WriteLine("La lista esta vacia");
            }
        }

        public void Consultar()
        {
            nodo_alumno Buscador = new nodo_alumno();
            Buscador = Primero;
            int Contador = 0;

            if (Primero != null)
            {
                while (Buscador != null)
                {
                    Buscador = Buscador.Siguiente; //Asigno el nodo al siguiente para mostrarlo
                    Contador++;
                }
                Console.WriteLine($"Hay {Contador} alumnos cargados");
            }
            else
            {
                Console.WriteLine("La lista esta vacia");
            }
        }

        public void Peek()
        {
            nodo_alumno Buscador = new nodo_alumno();
            Buscador = Primero;

            Console.WriteLine("Primer elemento:\n");
            Console.WriteLine($"{Buscador.Nombre}\t {Buscador.Apellido}\t {Buscador.FechaNac.ToString("dd/MM/yyyy")}");
        }
    }
}
