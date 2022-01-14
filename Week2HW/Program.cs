using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Week2HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double oil, tire, inspection;
            double total;
            string inputString;

            WriteLine("***Welcome to Phil's One-Stop Auto Shop***");
            ReadKey();

            WriteLine("How much was your oil change?");
            inputString = ReadLine();
            oil = Convert.ToDouble(inputString);

            WriteLine("How much was your tire change?");
            tire = Convert.ToDouble(ReadLine());

            WriteLine("How much was your car inspection?");
            inspection = Convert.ToDouble(ReadLine());

            total = oil + tire + inspection;
            
            Write(total);
            
            ReadKey();


            total = oil + tire + inspection




        }
    }
}
