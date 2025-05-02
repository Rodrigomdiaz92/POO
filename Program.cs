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
            Console.WriteLine(fordka.getautomovil());

            fordka.Acelerar(50);
            ds4.Acelerar(250);


            Console.WriteLine("Holi");


            DateTime nacimiento_rodri = new DateTime(1995, 10, 17);
            Cliente rodri = new Cliente("Rodrigo", "Diaz", 3857952, "DNI",nacimiento_rodri, 7890, "Responsable Inscripto");
            Console.WriteLine(rodri.getNombreCompleto());
            Console.WriteLine(rodri.getedad());
            Console.WriteLine(rodri.gettipo_iva());
            Console.WriteLine(rodri.getNombreCompleto() + " tiene " + rodri.getedad() + " años y es " + rodri.gettipo_iva());


            Cliente lucas = new Cliente("Lucas", 3857952, "DNI",nacimiento_rodri, 7890, "Responsable Inscripto");
            Console.WriteLine(lucas.getNombreCompleto());
            Console.WriteLine(lucas.getedad());
        }
    }
    
}
