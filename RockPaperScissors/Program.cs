using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock-Paper-Scissors!");
            Console.WriteLine("Please enter your choice (rock, paper, or scissors):");

            //store user choice
            string userChoice = Console.ReadLine();
            //Console.WriteLine("You choose: " + userChoice);

            //compute the non pc move through random choice
            Random random = new Random();
            string[] choices = { "rock", "paper", "scissors" };
            string computedChoice = choices[random.Next(choices.Length)];

            Console.WriteLine("You chose: " + userChoice);
            Console.WriteLine("Your opponent chose: " + computedChoice);


            //determining the winner
            if (userChoice == computedChoice)
            {
                Console.WriteLine("It is a tie!");
            } else if (
                (userChoice == "rock" && computedChoice == "scissors") ||
                (userChoice == "paper" && computedChoice == "rock") ||
                (userChoice == "scissors" && computedChoice == "paper"))
                {
                Console.WriteLine("You win!");

            } else
            {
                Console.WriteLine("PC Wins!");
            }
            Console.ReadLine();
        }
    }
}
