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

            Colour color  = new Colour(94,0,0,0);
            Colour red = new Colour(94, 0, 0, 0); Colour green = new Colour(0, 94, 0, 0);
            //  Console.WriteLine(color.colour);
            //Console.WriteLine(Colour.ConvertToBitString(color.colour));
            //Console.WriteLine(Colour.ConvertToBitString(color.red));
            Console.WriteLine("Before:");
            Console.WriteLine("GREEN");
            Console.WriteLine(green.colour);
            Console.WriteLine(Colour.ConvertToBitString(green.colour));
            Console.WriteLine("RED");
            Console.WriteLine(red.colour);
            Console.WriteLine(Colour.ConvertToBitString(red.colour));

            red.colour >>= 8;
            Console.WriteLine("After:");
            Console.WriteLine("GREEN");
            Console.WriteLine(green.colour);
            Console.WriteLine(Colour.ConvertToBitString(green.colour));
            Console.WriteLine("RED");
            Console.WriteLine(red.colour);
            Console.WriteLine(Colour.ConvertToBitString(red.colour));


        }
    }
}
