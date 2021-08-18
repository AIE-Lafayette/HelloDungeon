using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDungeon
{
    class Game
    {
        public void Run()
        {
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
            string name = "Empty";
            Console.WriteLine("Please enter your name.");
            name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);

            string characterName = "";
            int currentArea = 1;
            float power = 10.0f;
            string characterJob = "";
            bool gameOver = false;
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
        }
    }
}
