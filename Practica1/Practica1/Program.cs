using System;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            //objeto
            Empleado emp1 = new Empleado();

            //leer datos por teclado
            emp1.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el Nombre");
            emp1.Numsecsoc = Console.ReadLine();
            Console.WriteLine("Ingrese el Numero de seguro");
            emp1.PrimerApellido = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido");
            emp1.Edad = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la edad");

            Console.WriteLine(emp1.Nombre);
            Console.WriteLine(emp1.Numsecsoc);
        }
    }
}
