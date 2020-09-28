using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAdventureLib;

namespace ConsoleUI
{
    public class BuildPlayer
    {
        public static void BuildAPlayer(List<Player> inputList)
        {

            Player thisPlayer = new Player();
            bool error = false;
            string password;

            Console.Write("Enter your player name --> ");
            thisPlayer.Name = Console.ReadLine();
            do
            {
                Console.Write("Enter your password --> ");
                password = Console.ReadLine();
                if (password.Length >= 8 && password.Length <= 15 && NumberLowerCase(password) >= 1
                    && NumberUpperCase(password) >= 1 && NumberDigits(password) >= 1
                    && NumberPunctuation(password) >= 1)
                {
                    thisPlayer.Password = password;
                    error = false;
                }
                else
                {
                    Console.WriteLine("Error your password did not meet the requirements.");
                    error = true;
                }
            } while (error == true);


            Console.Write("Choose a class(Warrior, Rogue, Mage, Paladin) --> ");
            thisPlayer.Class = Console.ReadLine();
            Console.Write("Choose a race(Human, Halfling, Elf, Kobold) --> ");
            thisPlayer.Race = Console.ReadLine();
            thisPlayer.Health = 100;

            inputList.Add(thisPlayer);

        }
        private static int NumberLowerCase(string input)
        {
            int lowerCase = 0;
            foreach (char ch in input)
            {
                if (char.IsLower(ch))
                {
                    lowerCase++;
                }
            }
            return lowerCase;
        }
        private static int NumberUpperCase(string input)
        {
            int upperCase = 0;
            foreach (char ch in input)
            {
                if (char.IsUpper(ch))
                {
                    upperCase++;
                }
            }
            return upperCase;

        }
        private static int NumberPunctuation(string input)
        {
            int punctuation = 0;
            foreach (char ch in input)
            {
                if (char.IsPunctuation(ch))
                {
                    punctuation++;
                }
            }
            return punctuation;
        }
        private static int NumberDigits(string input)
        {
            int digit = 0;
            foreach (char ch in input)
            {
                if (char.IsDigit(ch))
                {
                    digit++;
                }
            }
            return digit;
        }
    }
}
