using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace inheritancecode
{
   class Computer 
     { 
       public void mainofcomputer() { 
       Console.WriteLine(“Every computer also has CPU.”); 
      } 
     }
   class Ram : Computer { 
      public void Feature() { 
      Console.WriteLine(“Ram is used to be able to storage activity data of computer.”); 
      } 
     }
   class Computernumber1 : Ram 
   { 
   public void Run() {
    Console.WriteLine(“Running”); 
      }   
  static void Main(string[] args) { 
    Run r = new Run(); 
    r.Computer(); 
    r.Ram(); 
    r.Run(); 
    } 
   }

}