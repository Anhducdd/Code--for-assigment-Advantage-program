using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulationexamplecode
{
    class Computer
    {
        private string name;
        private string price;
        public string Name {
            get { return name; }
            set { name = value; }
        }
        public string Price
        {
            get { return price; }
            set { price = value; }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Computer u = new Computer();
            u.Name = "Asus X542UQ";
            u.Price = "2000$";
            Console.WriteLine("Name:" + u.Name);
            Console.WriteLine("Price:" + u.Price);
            Console.ReadLine();

        }
    }
}
