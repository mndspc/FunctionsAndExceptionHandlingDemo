using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndExceptionHandling
{
    //  This program demo. how to pass arguments to main
    class PassArgumentToMain
    {
        static void Main(string[] args)
        {
            foreach(var str in args)
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}
