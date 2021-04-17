using System;
namespace tp2Obligatorio.Model
{
    public class ArbolBinario
    {
        public Nodo Raiz { get; set; }
        private int i = 0;
        public bool Agregar(int value)
        {
            Nodo antes = null;
            Nodo despues = this.Raiz;

            while (despues != null)
            {
                antes = despues;
                if (value < despues.Dato) //verifico si hay nodo a la izquierda
                    despues = despues.NodoIzquierda;
                else if (value > despues.Dato) //verifico si hay nodo a la derecha
                    despues = despues.NodoDerecha;
                else
                {
                    //arbol esta vacio
                    return false;
                }
            }

            Nodo NuevoNodo = new Nodo
            {
                Dato = value
            };

            if (this.Raiz == null)//arbol vacio
                this.Raiz = NuevoNodo;
            else
            {
                if (value < antes.Dato)
                    antes.NodoIzquierda = NuevoNodo;
                else
                    antes.NodoDerecha = NuevoNodo;
            }

            return true;
        }

        public Nodo Buscar(int value)
        {
            return this.Buscar(value, this.Raiz);
        }
        private Nodo Buscar(int value, Nodo padre)
        {
            if (padre != null)
            {
                if (value == padre.Dato)
                {
                    return padre;
                }
                if (value < padre.Dato)
                {
                    return Buscar(value, padre.NodoIzquierda);
                }
                else
                {
                    return Buscar(value, padre.NodoDerecha);
                }
            }

            return null;
        }

        public void Eliminar(int value)
        {
            this.Raiz = Eliminar(this.Raiz, value);
        }

        private Nodo Eliminar(Nodo padre, int key)
        {
            if (padre == null) return padre;

            if (key < padre.Dato) padre.NodoIzquierda = Eliminar(padre.NodoIzquierda, key);
            else if (key > padre.Dato)
                padre.NodoDerecha = Eliminar(padre.NodoDerecha, key);

            //Proceso 
            else
            {
                if (padre.NodoIzquierda == null)
                    return padre.NodoDerecha;
                else if (padre.NodoDerecha == null)
                    return padre.NodoIzquierda;

                //Obtengo el sucesor en orden
                padre.Dato = MinValue(padre.NodoDerecha);

                //Elimino en orden
                padre.NodoDerecha = Eliminar(padre.NodoDerecha, padre.Dato);
            }

            return padre;
        }

        private int MinValue(Nodo nodo)
        {
            int minv = nodo.Dato;

            while (nodo.NodoIzquierda != null)
            {
                minv = nodo.NodoIzquierda.Dato;
                nodo = nodo.NodoIzquierda;
            }

            return minv;
        }

        public int Amplitud()
        {
            return this.Amplitud(this.Raiz);
        }

        private int Amplitud(Nodo padre)
        {
            return padre == null ? 0 : Math.Max(Amplitud(padre.NodoIzquierda), Amplitud(padre.NodoDerecha)) + 1;
        }


        /* ordeno los datos para que se puedan entender los recorridos */
        public void PreOrden(Nodo padre)
        {
            if (padre == null)
                return;

            for (int n = 0; n < i; n++)
                Console.Write(" |");

            Console.WriteLine(padre.Dato);

            if (padre.NodoIzquierda != null)
            {
                i++;
                Console.Write("I");
                PreOrden(padre.NodoIzquierda);
                i--;
            }

            if (padre.NodoDerecha != null)
            {
                i++;
                Console.Write("D");
                PreOrden(padre.NodoDerecha);
                i--;
            }
        }

        public void InOrden(Nodo padre)
        {
            if (padre == null)
                return;

            for (int n = 0; n < i; n++)
                Console.Write(" |");

            if (padre.NodoIzquierda != null)
            {
                i++;
                Console.Write("I");
                InOrden(padre.NodoIzquierda);
                i--;
            }

            Console.WriteLine(padre.Dato);

            if (padre.NodoDerecha != null)
            {
                i++;
                Console.Write("D");
                InOrden(padre.NodoDerecha);
                i--;
            }
        }

        public void PostOrden(Nodo padre)
        {
            if (padre == null)
                return;

            for (int n = 0; n < i; n++)
                Console.Write(" |");

            if (padre.NodoIzquierda != null)
            {
                i++;
                Console.Write("I");
                PostOrden(padre.NodoIzquierda);
                i--;
            }

            if (padre.NodoDerecha != null)
            {
                i++;
                Console.Write("D");
                PostOrden(padre.NodoDerecha);
                i--;
            }

            Console.WriteLine(padre.Dato);
        }
    }
}