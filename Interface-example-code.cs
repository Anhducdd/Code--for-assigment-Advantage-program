using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_example_code
{
    interface somemath
    {
        double operation();
    }
    class devide : somemath
    {
        double _number1;
        double _number2;
        public devide(double input1, double input2)
        {
            _number1 = input1;
            _number2 = input2;
        }
        public double operation()
        {
            return _number1 / _number1;
        }



    }
    class Program {
        static void Main(string[] args)
        {
            devide obj = new devide(20.5,10.5);
            if (obj is somemath)
            {
                Console.WriteLine("The result: {0:F2}",
                    obj.operation());
            }
            else
            {
                Console.WriteLine("Interface method not implemented");
            }
            Console.ReadLine();
        }

    }

   
}

