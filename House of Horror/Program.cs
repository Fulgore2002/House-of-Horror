using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

/*
House of Horror
In this game you play as an anonymous adventurer trying to make a name for themselves by being the first to explore an old and forgotten house.
This game is going to be about exploring an old, haunted house trying to find jewels or cash (Money).
You will also find items that you can take and use in other rooms to help you get through the house.
Tyler Hitchcock
10/16/2024
Credits: help from YouTuber Shaun Halverson video
*/

namespace House_Of_Horror
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            while (playAgain)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                DisplayTitle();
                Console.ResetColor();

                // Prompt for the player's name
                Console.WriteLine("Enter your player's name:");
                string playerName = Console.ReadLine();

                // Create a Player object
                Player player = new Player(playerName);

                Rooms rooms = new Rooms(player);

                // Start the game
                rooms.PlayGame();

                // After the game ends
                Console.WriteLine("Game Over. Do you want to play again? (yes/no)");
                string playAgainResponse = Console.ReadLine();

                if (playAgainResponse.ToLower() != "yes")
                {
                    playAgain = false; // Exit the loop if the player does not want to play again
                }

                Console.Clear();
            }
        }

        public static void DisplayTitle()
        {
            Console.WriteLine(@" ██░ ██  ▒█████   █    ██   ██████ ▓█████     ▒█████    █████▒    ██░ ██  ▒█████   ██▀███   ██▀███   ▒█████   ██▀███  
▓██░ ██▒▒██▒  ██▒ ██  ▓██▒▒██    ▒ ▓█   ▀    ▒██▒  ██▒▓██   ▒    ▓██░ ██▒▒██▒  ██▒▓██ ▒ ██▒▓██ ▒ ██▒▒██▒  ██▒▓██ ▒ ██▒
▒██▀▀██░▒██░  ██▒▓██  ▒██░░ ▓██▄   ▒███      ▒██░  ██▒▒████ ░    ▒██▀▀██░▒██░  ██▒▓██ ░▄█ ▒▓██ ░▄█ ▒▒██░  ██▒▓██ ░▄█ ▒
░▓█ ░██ ▒██   ██░▓▓█  ░██░  ▒   ██▒▒▓█  ▄    ▒██   ██░░▓█▒  ░    ░▓█ ░██ ▒██   ██░▒██▀▀█▄  ▒██▀▀█▄  ▒██   ██░▒██▀▀█▄  
░▓█▒░██▓░ ████▓▒░▒▒█████▓ ▒██████▒▒░▒████▒   ░ ████▓▒░░▒█░       ░▓█▒░██▓░ ████▓▒░░██▓ ▒██▒░██▓ ▒██▒░ ████▓▒░░██▓ ▒██▒
 ▒ ░░▒░▒░ ▒░▒░▒░ ░▒▓▒ ▒ ▒ ▒ ▒▓▒ ▒ ░░░ ▒░ ░   ░ ▒░▒░▒░  ▒ ░        ▒ ░░▒░▒░ ▒░▒░▒░ ░ ▒▓ ░▒▓░░ ▒▓ ░▒▓░░ ▒░▒░▒░ ░ ▒▓ ░▒▓░
 ▒ ░▒░ ░  ░ ▒ ▒░ ░░▒░ ░ ░ ░ ░▒  ░ ░ ░ ░  ░     ░ ▒ ▒░  ░          ▒ ░▒░ ░  ░ ▒ ▒░   ░▒ ░ ▒░  ░▒ ░ ▒░  ░ ▒ ▒░   ░▒ ░ ▒░
 ░  ░░ ░░ ░ ░ ▒   ░░░ ░ ░ ░  ░  ░     ░      ░ ░ ░ ▒   ░ ░        ░  ░░ ░░ ░ ░ ▒    ░░   ░   ░░   ░ ░ ░ ░ ▒    ░░   ░ 
 ░  ░  ░    ░ ░     ░           ░     ░  ░       ░ ░              ░  ░  ░    ░ ░     ░        ░         ░ ░     ░     
                                                                                                                      
");
        }
    }
}
