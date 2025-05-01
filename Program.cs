using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Clase4 // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {

            //codigo principal
            Console.WriteLine("Hello World!");
            Automovil fordka; // se creo un objeto
            fordka = new Automovil("Ford", "KA", 200);// una forma de declarar
            Automovil ds4 = new Automovil("Citroen", "DS4", 220); // otra forma

            fordka.Acelerar(50);
            ds4.Acelerar(250);


            Console.WriteLine("Holi");
        }
    }
    
}
