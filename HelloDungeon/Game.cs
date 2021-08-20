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

            while (inputReceived != 1 && inputReceived != 2)
            {
                //Job selection menu
                Console.WriteLine(description);
                Console.WriteLine("1. " + option1);
                Console.WriteLine("2. " + option2);
                Console.Write("> ");

                //Get input from player
                input = Console.ReadLine();

                //If player selected the first option...
                if (input == "1" || input == option1)
                {
                    return 1;
                }
                //Otherwise if the player selected the second option...
                else if (input == "2" || input == "Knight")
                {
                    //...give the player the stats for a knight
                    characterJob = "Knight";
                }
                //If neither are true...
                else
                {
                    //...display error message
                    Console.WriteLine("Invalid Input");
                }

                Console.ReadKey();
                Console.Clear();
            }
            return 0;
        }

        public void Run()
        {
            DisplayPlayerStats();

            int sum = AddTwoNumbers(2, 2);
            Console.WriteLine(AddTwoNumbers(2, 2));
            //Health exercise

            //Initialize default health values
            int healthRegen = 50;
            int health = 100 / 2;
            //Increase health by regen amount
            health = health + healthRegen;
            health += healthRegen;
            //Display health to user
            Console.WriteLine(health);

            //Name exercise
            
            Console.WriteLine("Please enter your name.");
            characterName = Console.ReadLine();
            Console.WriteLine("Hello, " + characterName);

           
            //Test commit

            /// Create the start screen for your text adventure game.
            /// Use variables to store data for the game.
            /// These variables can include, but aren't limited to:
            /// a string to store a character name, a int to store
            /// the current area, an float to power,
            /// a string to store a character's job,
            /// and a bool to store whether or not the game is over.
            /// Afterwards, create the starting screen. It can be a 
            /// welcome message, a way for the player to initialize
            /// base stats, or anything else to comes to mind.
            ///

            

            //Display character stats
            Console.WriteLine("Your Character Stats\n");
            Console.WriteLine("Name: " + characterName);
            Console.WriteLine("Job: " + characterJob);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Power: " + power);

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("You've been approached by a traveler!!" +
                "\n They offer you a potion. Do you accept?" +
                "\n 1.Yes \n 2.No");

            //input = Console.ReadLine();

            //if (input == "1")
            //{
            //    Console.WriteLine("It was posion!! Ya dead shuuuunnnnn");
            //}
            //else if (input == "2")
            //{
            //    Console.WriteLine("You're worried about the weird beverage, so you ask the traveler to try it first.");

            //}

            int numberOfAttempts = 4;

            for (int i = 0; i < numberOfAttempts; i++)
            {
                Console.Clear();

                Console.WriteLine( "     __\n" +
                                   "w  c(..)o   (\n" +
                                   " \\__(-)   __)\n" +
                                   "    /|   (\n" +
                                   "   /(_)___)\n" +
                                   "  w /|\n" +
                                   "   \\  \n" +
                                   "    m m");


                Console.WriteLine("A very old man with a monkey oon his back approaches you." +
                "\n The monkey offers you immortality if you can solve a riddle in " + numberOfAttempts + " attempts.");
                Console.WriteLine("What has to be broken before you can use it?");
                int attemptsRemaining = numberOfAttempts - i;
                Console.WriteLine("Attempts Remaining: " + attemptsRemaining);
                Console.Write("> ");
                //input = Console.ReadLine();

                //if (input == "egg")
                //{
                //    Console.WriteLine("Congrats! You've gained immortality!");
                //    break;
                //}

                Console.WriteLine("Incorrect! The monkey laughs at you! It hurts..." +
                    "you take 5 points of damage.");
                health -= 5;
            }
        }
    }
}
