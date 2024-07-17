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
            bool playAgain = true;

            //play again
            while (playAgain)
            {
                PlayGame();
                playAgain = AskPlayAgain();
            }

            Console.WriteLine("Thank you for playing, Goodbye!");

        }
   
        static void PlayGame () {

            string userInput = GetUserChoice();
            string computedChoice = GetComputedChoice();

            Console.WriteLine("You chose: " + userInput);
            Console.WriteLine("Your opponent chose: " + computedChoice);

            DetermineWinner(userInput, computedChoice);
        }

        static string GetUserChoice () {
            //user input
            string userInput;
            while(true)
            {
                Console.WriteLine("Please enter your choice (rock, paper, or scissors):");
                userInput = Console.ReadLine().ToLower();
                if (userInput == "rock" || userInput == "paper" || userInput == "scissors")
                {
                    break;
                } else
                {
                    Console.WriteLine("Wrong choice! Please try again!");
                }

            }
            return userInput;
        }

        static string GetComputedChoice () {
            Random random = new Random();
            string[] choices = { "rock", "paper", "scissors" };
            return choices[random.Next(choices.Length)];
        }

        static void DetermineWinner(string userChoice, string computedChoice)
        {
        if (userChoice == computedChoice)
            {
                Console.WriteLine("It is a Draw!");
            } else if ((userChoice == "rock" && computedChoice == "scissors") ||
                     (userChoice == "rock" && computedChoice == "paper") ||
                     (userChoice == "scissors" && computedChoice == "paper"))
                {
                Console.WriteLine("You win!");
            } else
            {
                Console.WriteLine("You Loose!");
            }

        }
        
        static bool AskPlayAgain() {
        while (true)
            {
                Console.WriteLine("Would you like to play again? (yes or no)");
                string userInput = Console.ReadLine().ToLower();

                if (userInput == "yes")
                {
                    return true;
                } else if ( userInput == "no")
                {
                    return false;
                } else
                {
                    Console.WriteLine("Invalid choice! (Pick either yes or no)");
                }
            }
        }
    }
}


//Console.WriteLine("Welcome to Rock-Paper-Scissors!");
//Console.WriteLine("Please enter your choice (rock, paper, or scissors):");

////store user choice
//string userChoice = Console.ReadLine();
////Console.WriteLine("You choose: " + userChoice);

////compute the non pc move through random choice
//Random random = new Random();
//string[] choices = { "rock", "paper", "scissors" };
//string computedChoice = choices[random.Next(choices.Length)];

//Console.WriteLine("You chose: " + userChoice);
//Console.WriteLine("Your opponent chose: " + computedChoice);


////determining the winner
//if (userChoice == computedChoice)
//{
//    Console.WriteLine("It is a tie!");
//} else if (
//    (userChoice == "rock" && computedChoice == "scissors") ||
//    (userChoice == "paper" && computedChoice == "rock") ||
//    (userChoice == "scissors" && computedChoice == "paper"))
//    {
//    Console.WriteLine("You win!");

//} else
//{
//    Console.WriteLine("PC Wins!");
//}
//Console.ReadLine();