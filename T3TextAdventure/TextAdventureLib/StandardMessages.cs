using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureLib
{
    public class StandardMessages
    {
        public static string Menu()
        {
            return "Choose an option:" +
                    "\n1. New Player" +
                    "\n2. Returning Player" +
                    "\n3. Exit" +
                    "\n--> ";
        }
        public static string MenuError()
        {
            return "Invalid input! Please select a number from the menu.";
        }
        public static string GameError()
        {
            return "Invalid input! Please type \"go (cardinal direction)\" to move or attack to attack a mob." +
                "\nYou can type exit to get back to the main menu.";
        }

        public static string RoomMove()
        {
            return "You have moved to room: ";
        }

        public static string GameWelcome()
        {
            return "Welcome to the game!";
        }

        public static string GetPlayerName()
        {
            return "Enter your player name: ";
        }
        public static string GetPlayerPassword()
        {
            return "Enter your password: ";
        }
        public static string DisplayPasswordError()
        {
            return "Invalid password";
        }

        public static string DisplayReturnPlayerError()
        {
            return "No player exists under that name.";
        }
    }
}
