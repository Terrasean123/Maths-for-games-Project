using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Colour color  = new Colour(0,255,255,255);
            Console.WriteLine(color.colour);
            Console.WriteLine(Colour.ConvertToBitString(color.colour));
         
        }
    }
}
