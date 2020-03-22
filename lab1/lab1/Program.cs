using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
     class Program
    {
        static void Main(string[] args)
        {
            Person persona1 = new Person();
     
            Console.WriteLine(persona1.Getname());
            Console.WriteLine(persona1.Lanzar());
            Console.ReadKey();

        }
    }
}
