using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("inserta el precio del primer articulo");
            int A1= int.Parse(Console.ReadLine());
            System.Console.WriteLine("inserta el precio del segundo articulo");
            int A2 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("inserta el precio del tercer articulo");
            int A3 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("inserta el precio del cuarto articulo");
            int A4 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("inserta el precio del quinto articulo ");
            int A5 = int.Parse(Console.ReadLine());
            int T= A1 + A2 + A3 + A4+A5;
            if (T > 2000) 
            {
              System.Console.WriteLine("feliocidades acabas de ganar un descuento");
                System.Console.WriteLine("el total a pagar es de:"+T);
                System.Console.WriteLine("el descuento otorgado es del 10%");
                int Td = (int)(T - (T * 0.10));
            }
            else 
            {
                System.Console.WriteLine("No a ganado descuemnto");
                System.Console.WriteLine("el total a pagar es de" + T);
            }
            Console.ReadKey();
        }
    }
}
