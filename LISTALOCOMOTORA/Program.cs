using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTALOCOMOTORA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Locomotora l = new Locomotora();
            l.AgregaFinal(2);
            l.AgregaFinal(40);
            l.AgregaFinal(20);
            l.AgregaFinal(30);
            l.AgregaFinal(5);
            l.AgregaFinal(100);
            l.AgregaFinal(80);


            Console.WriteLine("Antes de ordenar:");

            Console.WriteLine(l.VerVagones());

            l.AgregarLEFinal();

            Console.WriteLine("Después de ordenar:");

            Console.WriteLine(l.VerVagones());

            if (l.ExisteValor(50) == true)
            {
                Console.WriteLine("El valor 50 si existe en la lista");
            }
            else
            {
                Console.WriteLine("El valor 50 no existe en la lista");
            }

            l.Ordenar();
            Console.WriteLine("Asi se ve el orden: " + l.VerVagones());
        }
    }
}
