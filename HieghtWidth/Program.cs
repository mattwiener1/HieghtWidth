using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HieghtWidth
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var x = 0;
            do
            {
                Console.WriteLine("please enter the width of the image");
                var width = Console.ReadLine();

                if (!int.TryParse(width, out x)) Console.WriteLine("You did not enter a valid width");
            } while (x == 0);

            var y = 0;
            do
            {
                Console.WriteLine("please enter the hieght of the image");
                var width = Console.ReadLine();

                if (!int.TryParse(width, out y)) Console.WriteLine("You did not enter a valid hieght");
            } while (y == 0);

            if (x > y)
                Console.WriteLine("The image is in landscape");
            else if (x == y)
                Console.WriteLine("The image is a square");

            else
                Console.WriteLine("The image is in portrait");
        }
    }
}
