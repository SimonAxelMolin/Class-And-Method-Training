using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlsWorkFfs
{
    class Program
    {
       
        static void Main(string[] args)
        {


           NumberList();

            Console.WriteLine();
            Console.WriteLine(Program.FinishedNumber());
            
            Console.ReadKey();
        }

        static void NumberList()
        {
            int[] finNumbers = new int[5];

            Randomizer randomizer = new Randomizer();

            finNumbers = randomizer.NumberRandomizer();

            for (int i = 0; i<5; i++)
            {
                Console.WriteLine(finNumbers[i]);

            }
        }

        static int FinishedNumber()
        {
            int lastNumber;
            int[] finNumbers = new int[5];

            Randomizer randomizer = new Randomizer();

            finNumbers = randomizer.NumberRandomizer();

            lastNumber = finNumbers.Sum();

            return lastNumber;
        }
    }
}
