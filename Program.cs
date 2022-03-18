using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sataic_Constructor
{
    class Program
    {

        static int id=1;
        static string name="Ashish Ranjan";
        static Program()
        {
            Console.WriteLine("Your Id is: "+id);
            Console.WriteLine("Your Name is: " + name);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.ReadLine();
        }
    }
}
