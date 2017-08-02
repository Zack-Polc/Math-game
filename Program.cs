// Created by Zack Polc 15/05/2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_csharp_program
{
    class Program
    {
        // defining fields so that these variables work outside scope
        private static Int32 Correct;
        private static Int32 InCorrect;

        static void Main(string[] args) // Entry point of program  
        {
            PrintIntro();
            do
            {

            StartGame();
            } while (true);

        }

        // Print the ASCII art
        static void PrintIntro()
        {
            Console.WriteLine("             _      ");
            Console.WriteLine("            | |     ");
            Console.WriteLine("    ___ __ _| | ___ ");
            Console.WriteLine("   / __/ _` | |/ __|");
            Console.WriteLine("   | (_| (_|| | (__ ");
            Console.WriteLine("   \\___\\__,_|_|\\___|");
            Console.WriteLine("");
        }

        // Initialises the game session
        static void StartGame()
        {
            Console.WriteLine("");
            Console.WriteLine("Correct: " + Correct);
            Console.WriteLine("Incorrect: " + InCorrect);
            Console.WriteLine("");

            // calling a class that can generate random numbers
            Random NumberGenerator = new Random();
            Random OperatorGenerator = new Random();

            // Declare variables for the numbers
            int Number1 = NumberGenerator.Next(1, 13);
            int Number2 = NumberGenerator.Next(1, 13);

            Console.WriteLine("What is " + Number1 + " * " + Number2 + "?");
            // Create variable to save players answer
            int Answer = Convert.ToInt32(Console.ReadLine());

            if (Answer == Number1 * Number2)
            {
                Correct++;
                Console.WriteLine("Good Job!");
            }
            else
            {
                InCorrect++;
                int ResponseIndex = NumberGenerator.Next(1, 4);

                switch (ResponseIndex)
                {
                    case 1:
                        Console.WriteLine("Are you even trying?");
                        break;
                    case 2:
                        Console.WriteLine("The answer is wrong");
                        break;
                    default:
                        Console.WriteLine("you can do better than that");
                        break;

                }
            }
        }
        
    }
}

  
