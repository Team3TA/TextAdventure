﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAdventureLib;

namespace ConsoleUI
{
    public class BuildPlayer
    {
        public static Player BuildAPlayer()
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
                    Console.WriteLine("Error your password did not meet the requirements." +
                        "\nPassword requirements -" +
                        "\n1. Must be 8-15 characters long" +
                        "\n2. Must contain at least one upper case letter" +
                        "\n3. Must contain at least one lower case letter" +
                        "\n4. Must contain at least one punctuation mark" +
                        "\n5. Must contain at least one number");
                    error = true;
                }
            } while (error == true);


            Console.Write("Choose a class(Warrior, Rogue, Mage, Paladin) --> ");
            thisPlayer.Class = Console.ReadLine();
            Console.Write("Choose a race(Human, Halfling, Elf, Kobold) --> ");
            thisPlayer.Race = Console.ReadLine();
            thisPlayer.Health = 100;
            thisPlayer.Admin = false;
            

            StreamWriter outputfile = File.CreateText($@"../../../TextAdventureLib/Players/{thisPlayer.Name}.csv");
            outputfile.Write($"{thisPlayer.Name},{thisPlayer.Health},{thisPlayer.Password},{thisPlayer.Class},{thisPlayer.Race},{thisPlayer.Admin}");
            outputfile.Close();
            return thisPlayer;

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
