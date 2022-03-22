using System;

namespace SelectionStatementExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you guess the number I'm thinking of between 1 and 10?");
            var r = new Random();
            var favNumber = r.Next(1, 10);
            int userInput;
            do
            {
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine("too low");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("too high");
                }
                else
                {
                    Console.WriteLine("Nevermind");
                }
            } while (userInput != favNumber);

            Console.WriteLine("What is your favorite school subject?");
            var favClass = Console.ReadLine().ToLower();

            switch (favClass)
            {
                case "math":
                    Console.WriteLine("Yes! The universal language!");
                    break;
                case "english":
                    Console.WriteLine("Reading is cool. I guess");
                    break;
                case "history":
                    Console.WriteLine("History is the study of all the world's crime");
                    break;
                case "science":
                    Console.WriteLine("Never stop questioning");
                    break;
                case "gym":
                    Console.WriteLine("Go sports team!");
                    break;
                default:
                    Console.WriteLine("Really? That subject?");
                    break;
            }
        }
    }
}
