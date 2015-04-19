using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //FizzBuzz 1-20
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine(FizzBuzz(i));
            }

            //new line for readability
            Console.WriteLine();


            //show the number of "i"s in the following:
            Console.WriteLine(LetterCounter('i', "I love buscuits and gravy. It's the best breakfast ever."));

            //show the number of "n"s while getting "Rick Rolled", I just wanna tell you how I'm feeling...
            Console.WriteLine(LetterCounter('n', "Never gonna give you up. Never gonna let you down."));

            //show the number of "s"s in the following:
            Console.WriteLine(LetterCounter('s', "Sally sells seashells down by the seashore. She's from Sussex."));
            Console.ReadKey();

        }
        public static string FizzBuzz(int number)
        {
            //checks if numbers divisible by 3 and 5
            if ((number % 3) == 0 && (number % 5) == 0)
            {
                return ("FizzBuzz");
            }

            //checks if numbers divisible by 3
            else if ((number % 3) == 0)
            {
                return ("Fizz");
            }
            else if ((number % 5) == 0)
            {
                return ("Buzz");
            }
            else
            {
                return (number.ToString());
            }
        }
        public static string LetterCounter(char letter, string inString)
        {
            //set var for input string
            string input = inString;

            //holds number of upper case
            int numUpper = 0;

            //holds number of lower case
            int numLower = 0;

            //holds number of all matching characters
            int totalNumLetters = 0;

            //iterates though all characters checking for upper and lower of char letter
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLower(input[i]) && (input[i] == Char.ToLower(letter)))
                {
                    numLower++;
                }

                if (char.IsUpper(input[i]) && (input[i] == Char.ToUpper(letter)))
                {
                    numUpper++;
                }
            }

            //combines numbers of upper and lower characters for total
            totalNumLetters = numLower + numUpper;

            //added for readability
            Console.WriteLine();

            //returns input sentence and calculated values for upper/lower case and all matching chars found
            return ("The total numer of " + letter + "'s in '" + input + "' equals " + totalNumLetters + ". It has " + numLower + " lower case and " + numUpper + " upper case " + letter + "'s.");
        }
    }
}
