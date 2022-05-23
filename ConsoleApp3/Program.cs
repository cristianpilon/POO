using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Persona taro = new Persona();

            Persona mary = new Persona("Matías", 29);
            Persona amilcar = new Persona("Amilcar", 35);

            Console.WriteLine(mary.SaludoEnEspaniol());
            Console.WriteLine(taro.SaludoEnIngles());
            Console.WriteLine(amilcar.SaludoEnEspaniol());
        }
    }
}
