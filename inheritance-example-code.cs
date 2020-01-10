using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherittanceexamplecode
{
    
    class Computer
    {
        public void mainofcomputer()
        {
            Console.WriteLine("Computer didn't work without CPU.");
        }
    }
    class Ram : Computer
    {
        public void Feature()
        {
            Console.WriteLine("Ram is soft memories of computer.");
        }
    }
    class Computernumber1 : Ram
    {
        public void Run()
        {
            Console.WriteLine("Running...");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Computernumber1 r = new Computernumber1();
            r.mainofcomputer();
            r.Feature();
            r.Run();
            Console.ReadLine();
        }
    }
}
