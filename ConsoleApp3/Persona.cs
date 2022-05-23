using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Persona
    {
        public int Edad { get; set; }

        public string Nombre { get; set; }

        public Persona()
        {
            Nombre = "Lautaro";
            Edad = 20;
        }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public string SaludoEnEspaniol() 
        {
            return ArmarSaludo("Hola");
        }

        public string SaludoEnIngles()
        {
            return ArmarSaludo("Hello");
        }

        private string ArmarSaludo(string saludo)
        {
            if (Nombre == "Amilcar")
            {
                return saludo + " guacheeen!!!";
            }

            return saludo + " " + Nombre;
        }
    }
}
