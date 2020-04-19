using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdadPasada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Escriba su edad:");
            int age = Convert.ToInt32(Console.ReadLine());
            int oldAge = 10 + age;
            Console.WriteLine(" Su edad dentro de años es: {0}", oldAge);

            Console.ReadKey();
        }
    }
}
