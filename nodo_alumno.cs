using System;
namespace primerparcial
{
    class nodo_alumno
    {
        private string nombre;
        private string apellido;
        private nodo_alumno siguiente;
        DateTime fechanac = new DateTime();

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public nodo_alumno Siguiente { get => siguiente; set => siguiente = value; }
        public DateTime FechaNac { get => fechanac; set => fechanac = value; }
    }
}
