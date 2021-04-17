using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpObligatorio
{
    class Classlista
    {
        Nodo primer_nodo = new Nodo();
        Nodo ultimo_nodo = new Nodo();
        
        public Classlista()
        {
            primer_nodo = null;
            ultimo_nodo = null;
        }
        private int cantidad;
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public void CargarAlumno(string nombre) // Carga nombre a la cola
        {
            Nodo nuevo = new Nodo();
            nuevo.ingresaralumno(nombre);

            if (primer_nodo == null)
            {
                primer_nodo = nuevo;
                primer_nodo.siguiente_nodo = null;
                ultimo_nodo = primer_nodo;
            }
            else
            {
                ultimo_nodo.siguiente_nodo = nuevo;
                nuevo.siguiente_nodo = null;
                ultimo_nodo = nuevo;
            }
            cantidad++;
        }
        public string[] DevolverCola() //Imprime toda la cola
        {

            string[] cola = new string[cantidad];

            if (primer_nodo != null)
            {
                Nodo aux = new Nodo();
                aux = primer_nodo;
                int i = 0;

                while (aux != null)
                {
                    cola[i] = aux.obteneralumno();
                    aux = aux.siguiente_nodo;
                    i++;
                }

            }
            return cola;
        }

        public string AlumnoTope() //Devuelve el primer registrado;
        {
            string tope;
            if (primer_nodo != null)
            {
                tope = primer_nodo.obteneralumno();
            }
            else
            {
                tope = "Aun no cargado ningun nombre";
            }
            return tope;
        }
        public string EliminarAlumno() // Carga nombre a la cola
        {
            string eliminado;
            if (primer_nodo == null)
            {

                eliminado = "La Cola esta vacia";
            }
            else
            {
                eliminado = primer_nodo.obteneralumno();
                primer_nodo = primer_nodo.siguiente_nodo;

            }
            cantidad--;
            return eliminado;
        }
    }
}
