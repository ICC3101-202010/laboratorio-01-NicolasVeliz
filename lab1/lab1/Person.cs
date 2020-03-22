using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Person
    {
        public string Name;
        public string Lastname;

        public int Lanzar()
        {
            Random rand = new Random();
            int Lanzar = rand.Next(0, 3);
            return Lanzar;
        }
        public Person()
        {
            Name = "Bob Kunga";
        }
        public Person(string name, string lastname)
        {
            this.Name = name;
            this.Lastname = lastname;

        }
        public string Getname()
        {
            return Name;

        }


    }
    

}
