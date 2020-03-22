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
            Person persona1 = new Person("Bob","Kunga");
            //persona1.Name = "Bob";
            //persona1.Lastname = "Kunga";





            Console.WriteLine(persona1.Name);
            Console.WriteLine(persona1.Lastname);
            Console.WriteLine(persona1.Lanzar());
            Console.ReadKey();

        }
    }
}
