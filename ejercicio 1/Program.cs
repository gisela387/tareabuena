using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            vehiculo vehiculo = new vehiculo(01, "toyota", "Chevrolet", 7000, 12000, 2015);
            Console.WriteLine("datos del vehiculo");
            Console.WriteLine(vehiculo.ToString());
            Console.ReadKey();
        }
    }
}
