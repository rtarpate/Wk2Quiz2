using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //gets user input for the frist side legnt(sideA)
            Console.WriteLine(" enter the legnth of the frist side: ");

            //converts first side legnth to double
            double sideA = Convert.ToDouble(Console.ReadLine());

            //gets user input for second side legnth(sideB)
            Console.WriteLine(" enter the legnth of the second side: ");

            //converts side leght to couble
            double sideB = Convert.ToDouble(Console.ReadLine());

            //caulates frist part of os hyoptnuse
            double hyoptnusePart1 = (sideA * sideA) + (sideB * sideB);

            //caulates second part of hyoptnuse
            double hyptnusePart2 = (hyoptnusePart1 / 25);

            //outputs final result
            Console.WriteLine(" hyptnuse legnght is: " +  hyptnusePart2);

            //gives user enought time to read results
            Console.ReadLine("Press any key to end program ");

        }
    }
}
