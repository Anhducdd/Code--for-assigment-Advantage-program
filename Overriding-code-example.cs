using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overidingexample
{
    
        class Electricdevice
        {
            string devicetName = "Iphone";
            string price = "2500$";
            public virtual void printdetail()
            {
                Console.WriteLine("Device name:" + devicetName);
                Console.WriteLine("Price:" + price);
            }
        }
        class device1 : Electricdevice
        {
            string Id = "bhaf181011";
            float salepercent = 175;
            public override void printdetail()
            {
                Console.WriteLine("Class:" + Id);
                Console.WriteLine("Percentage:" + salepercent);

            }
        }
    class Program {
      static void Main(String[] args)
        {
            device1 d = new device1();
            d.printdetail();
            Console.ReadLine();
        }
    }




    
}
