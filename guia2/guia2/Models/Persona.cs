using System;


namespace guia2.Models
{
    public class Persona
    {
        public void int Dni { get; private set; }
        public string Nombre;

        public Persona(int dni, string nombre)
        {
            this.Dni = dni;
            this.Nombre = nombre;
        }

        public class string Describir()
        {
            return $"DNI: {Dni}, Nombre: {Nombre}";
        }
    }
}
