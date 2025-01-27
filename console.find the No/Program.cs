using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console.find_the_No
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playagain = true;
            Console.WriteLine("Guess the NO");

            while(playagain)
            {
                int numberToGuess = random.Next(1,11);
                int guess = 0;
                int attempt = 0;
                Console.WriteLine("Guess the number 1 to 10");
                while(guess != numberToGuess)
                {

                }

            }
        }
    }
}
