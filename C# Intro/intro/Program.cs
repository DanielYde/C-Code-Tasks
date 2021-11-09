using System;

namespace intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();

            string val;
            int a = 0;
            int tries = 0;
            int numberOfTries = 5;
            bool finished = false;
            int randomNum = rd.Next(1,20);

            Console.WriteLine("Guess the random number between 1 and 20!");
            Console.WriteLine("You have " + numberOfTries + " tries");
            Console.WriteLine("It will tell you if the random number is above or below your guess");
            
            for (int i = 0; i <= tries; i++) {
                if (finished == false && tries < numberOfTries) {
                    Console.Write("Your guess: ");
                    val = Console.ReadLine();
                    a = Convert.ToInt32(val);

                    if (a > 20 || a < 1) {
                        Console.WriteLine("Please guess a number between 1 and 20");
                        i--;
                    } else {

                    if (a < randomNum) {
                        Console.WriteLine("The random number is larger than: {0}",a);
                    }
                    if (a > randomNum) {
                        Console.WriteLine("The random number is less than: {0}",a);
                    }
                    if (a == randomNum) {
                        Console.WriteLine("You have guessed the right number: {0}",a);
                        finished = true;
                    }
                    tries++;
                    }
                }
            }
            if (finished == false && tries >= numberOfTries) {
                Console.WriteLine("You failed to guess the right number!");
                Console.WriteLine("The correct number is: {0}",a);
            }
            Console.WriteLine("Press Any Key To Exit");
            Console.ReadKey();
        }
    }
}
