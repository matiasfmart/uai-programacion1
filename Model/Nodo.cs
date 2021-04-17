using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpObligatorio
{
    /*genero la clase nodo*/
    class Nodo
    {
        /*declaro los atributos*/
        public Alumno nodo_nombre = new Alumno();
        private Nodo siguiente;

        public string obteneralumno()
        {
            return nodo_nombre.Obtenernombre();
        }
        public void ingresaralumno(string nombre)
        {
            nodo_nombre.Ingresarnombre(nombre);
        }
        public Nodo siguiente_nodo
        {
            get
            {
                return siguiente;
            }
            set
            {
                siguiente = value;
            }
        }
    }
}
