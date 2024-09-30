using System.ComponentModel.Design;
using System.Runtime.InteropServices.Marshalling;

namespace Topic_5._3_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string guessOne, guessTwo, guessFour;
            int guessThree, points = 0;

            Console.WriteLine("Time for a Geography quiz!");
            Console.WriteLine();
            Console.WriteLine("Question 1: What is the capital of Hungary?");
            guessOne = Console.ReadLine().ToLower();
            if (guessOne == "budapest")
            {
                Console.WriteLine("Correct!");
                points += 1;
            }
            else
                Console.WriteLine("Incorrect!");
            Console.WriteLine();
            Console.WriteLine("Question 2: True or False: Canada is the second largest country in the world by size.");
            guessTwo = Console.ReadLine().ToLower();
            if (guessTwo == "true")
            {
                Console.WriteLine("Correct!");
                points += 1;
            }
            else
                Console.WriteLine("Incorrect!");
            Console.WriteLine();
            Console.WriteLine("Question 3: What is the area of russia in Millions of square km? any answer up to 2 million off will be correct.");
            Int32.TryParse(Console.ReadLine(), out guessThree);
            if (guessThree >= 15 && guessThree <= 19)
            {
                Console.WriteLine("Correct!");
                points += 1;
            }
            else
                Console.WriteLine("Incorrect!");
            Console.WriteLine();
            Console.WriteLine("Question 4: Which is the most populous country?");
            Console.WriteLine("1. China    2. India");
            Console.WriteLine("3. USA      4. Russia");
            guessFour = Console.ReadLine().ToLower();
            if (guessFour == "2" || guessFour == "india")
            {
                Console.WriteLine("Correct!");
                points += 1;
            }
            else
                Console.WriteLine("Incorrect!");
            Console.WriteLine();
            Console.WriteLine("The test is completed.");
            if (points == 0)
                Console.WriteLine("You got 0 questions right. You are dumb.");
            else if (points == 1)
                Console.WriteLine("You got 1 question right. Not a passing grade.");
            else if (points == 2)
                Console.WriteLine("You got 2 questions right. Barely a pass.");
            else if (points == 3)
                Console.WriteLine("You got 3 questions right! Nice job!");
            else if (points == 4)
                Console.WriteLine("You got all questions right! Excellent job!");
        }
            
    }
}
