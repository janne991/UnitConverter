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
            const int FeetsToInchesRatio = 12;
            const int MilesToFeetsRatio = 5280;

            Console.Write("Enter number of feets to convert to inches: ");
            int feets = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of miles to onvert to feet: ");
            int miles = Convert.ToInt32(Console.ReadLine());

            UnitConverter feetToInches = new UnitConverter(FeetsToInchesRatio);
            UnitConverter milesToFeet = new UnitConverter(MilesToFeetsRatio);

            Console.WriteLine();
            Console.WriteLine("{0} feets is equal to {1} inches",feets,feetToInches.Convert(feets));
            Console.WriteLine("{0} miles is equal to {1} feets",miles,milesToFeet.Convert(miles));

            Console.WriteLine();
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
