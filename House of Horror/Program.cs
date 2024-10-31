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
            Console.ForegroundColor = ConsoleColor.Red;
            DisplayTitle();
            Console.ResetColor();

            Console.WriteLine("Enter your player's name:");
            string playerName = Console.ReadLine();

            Player player = new Player(playerName); // Create a Player object
            Rooms rooms = new Rooms(player); // Pass the Player object to the Rooms constructor
            rooms.PlayGame();
        }

        public static void DisplayTitle()
        {
            Console.WriteLine(@"
 ██░ ██  ▒█████   █    ██   ██████ ▓█████     ▒█████    █████▒    ██░ ██  ▒█████   ██▀███   ██▀███   ▒█████   ██▀███  
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
