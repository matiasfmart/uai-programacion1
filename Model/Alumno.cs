using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpObligatorio
{
    class Alumno
    {
        private string nombre;
        public string Obtenernombre()
        {
            return nombre;
        }
        public void Ingresarnombre(string dato_nombre)
        {
            nombre = dato_nombre  ;
        }

    }
}
