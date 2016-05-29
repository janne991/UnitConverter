using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitConverter feetToInches = new UnitConverter(12);
            UnitConverter milesToFeet = new UnitConverter(5280);

            Console.WriteLine(feetToInches.Convert(30));
            Console.WriteLine(feetToInches.Convert(100));
            Console.WriteLine(feetToInches.Convert
                            (milesToFeet.Convert(1)));
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
