using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDungeon
{

    class Game
    {
        string characterName = "";
        int currentArea = 1;
        float power = 10.0f;
        string characterJob = "No Job";
        bool gameOver = false;
        int healthRegen = 50;
        int health = 100;
        bool playerIsAlive = true;

        /// <summary>
        /// Prints all even numbers in the range [num1..num2]
        /// </summary>
        /// <param name="num1">The starting number.</param>
        /// <param name="num2">The ending number.</param>
        void PrintAllEven(int num1, int num2)
        {
            for (int i = num1; i <= num2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        int AddTwoNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        void PrintBird(string word, int copies)
        {
            if (word != "Bird")
            {
                return;
            }
            
            for (int i = 0; i < copies; i++)
            {
                Console.WriteLine(word);
            }
            
        }

        void Room1()
        {
            Console.WriteLine("Please enter your name.");
            characterName = Console.ReadLine();
            Console.WriteLine("Hello, " + characterName);

            DisplayPlayerStats();

            Console.Clear();

            int input = GetInput("You've been approached by a traveler!! " +
                "\n They offer you a potion. Do you accept?", "1. Yes", "2. No");
           
            if (input == 1)
            {
                Console.WriteLine("It was posion!! Ya dead shuuuunnnnn");
                playerIsAlive = false;
            }
            else if (input == 2)
            {
                Console.WriteLine("You're worried about the weird beverage, so you ask the traveler to try it first.");

            }
        }

        void Room2()
        {
            int numberOfAttempts = 4;
            string input = "";

            for (int i = 0; i < numberOfAttempts; i++)
            {
                Console.Clear();

                Console.WriteLine("     __\n" +
                                   "w  c(..)o   (\n" +
                                   " \\__(-)   __)\n" +
                                   "    /|   (\n" +
                                   "   /(_)___)\n" +
                                   "  w /|\n" +
                                   "   \\  \n" +
                                   "    m m");


                Console.WriteLine("A very old man with a monkey on his back approaches you." +
                "\n The monkey offers you immortality if you can solve a riddle in " + numberOfAttempts + " attempts.");
                Console.WriteLine("What has to be broken before you can use it?");
                int attemptsRemaining = numberOfAttempts - i;
                Console.WriteLine("Attempts Remaining: " + attemptsRemaining);
                Console.Write("> ");
                input = Console.ReadLine();

                if (input == "egg")
                {
                    Console.WriteLine("Congrats! You've gained immortality!");
                    Console.ReadKey();
                    break;
                }

                Console.WriteLine("Incorrect! The monkey laughs at you! It hurts..." +
                    "you take 5 points of damage.");
                Console.ReadKey();
                health -= 5;
            }
        }

        void DisplayMainMenu()
        {
            int input = GetInput("Would you like to play again?", "Yes", "No");

            if (input == 1)
            {
                currentArea = 1;
                gameOver = false;
            }
            else if (input == 2)
            {
                gameOver = true;
            }
        }

        void Room3()
        {
            Console.Clear();
            Console.WriteLine("This is room 3");
        }

        void DisplayPlayerStats()
        {
            Console.WriteLine(characterName + " stats:");
            Console.WriteLine("Job: " + characterJob);
            Console.WriteLine("Power: " + power);
        }

        int GetInput(string description, string option1, string option2)
        {
            string input = "";
            int inputReceived = 0;

            //While input is not 1 or 2 display the options
            while (!(inputReceived == 1 || inputReceived == 2))
            {
                //Print options
                Console.WriteLine(description);
                Console.WriteLine("1. " + option1);
                Console.WriteLine("2. " + option2);
                Console.Write("> ");

                //Get input from player
                input = Console.ReadLine();

                //If player selected the first option...
                if (input == "1" || input == option1)
                {
                    //Set input received to be the first option
                    inputReceived = 1;
                }
                //Otherwise if the player selected the second option...
                else if (input == "2" || input == option2)
                {
                    //Set input received to be the second option
                    inputReceived = 2;
                }
                //If neither are true...
                else
                {
                    //...display error message
                    Console.WriteLine("Invalid Input");
                    Console.ReadKey();
                }

                Console.Clear();
            }

            return inputReceived;
        }

        void DisplayCurrentRoom()
        {
            if (currentArea == 1)
            {
                Room1();
            }
            else if (currentArea == 2)
            {
                Room2();
            }
            else if (currentArea == 3)
            {
                Room3();
            }
        }

        public void Run()
        {
            //Loop while game isn't over
            while (!gameOver)
            {
                //Print the current room to the screen
                DisplayCurrentRoom();

                //If the player lost or beat the game...
                if (playerIsAlive == false || currentArea == 3)
                {
                    //...print main menu
                    DisplayMainMenu();
                }
                //Otherwise if the player is alive and hasn't finished...
                else
                {
                    //...increment the current area
                    currentArea++;
                }
            }
        }
    }
}
