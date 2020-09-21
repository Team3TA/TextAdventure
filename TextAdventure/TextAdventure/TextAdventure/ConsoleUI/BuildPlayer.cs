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
            
            Console.Write("Enter your player name --> ");
            thisPlayer.Name = Console.ReadLine();
            Console.Write("Enter your password --> ");
            thisPlayer.Password = Console.ReadLine();
            Console.Write("Choose a class(Warrior, Rogue, Mage, Paladin) --> ");
            thisPlayer.Class = Console.ReadLine();
            Console.Write("Choose a race(Human, Halfling, Elf, Kobold) --> ");
            thisPlayer.Race = Console.ReadLine();

            inputList.Add(thisPlayer);
            
        }
    }
}
