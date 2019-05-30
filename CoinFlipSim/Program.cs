using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlipSim
{
    class Program
    {
        static int randomNumber;
        static int amountHeads;
        static int amountTails;

        static void Main(string[] args)
        {
            Console.WriteLine("Amount of coinflips?");

            int input;
            Int32.TryParse(Console.ReadLine(), out input); //change user input to int
            
            Random randomGen = new Random();

            for (int i = 0; i < input; i++)
            {

                randomNumber = randomGen.Next(2); // random number between 0-1
                if (randomNumber == 0)
                {
                    Console.WriteLine("Heads");
                    amountHeads++;
                }
                else if (randomNumber == 1)
                {
                    Console.WriteLine("Tails");
                    amountTails++;
                }
                
            }
            Console.WriteLine("Total heads = " + amountHeads + " / Total Tails = " + amountTails);
            Console.WriteLine("End"); // end application
            Console.ReadKey();
        }
    }
}
