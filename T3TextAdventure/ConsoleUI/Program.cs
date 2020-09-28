/**
* 3/1/20
* CSC 153
* Brandon Dalton
* Text based adventure, program will simulate a text based adventure
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAdventureLib;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            
            List<Player> players = new List<Player>();         

            
            do
            {
                Console.WriteLine(StandardMessages.Menu());
                
                
                switch(Console.ReadLine())
                {
                    case "1":                    
                        BuildPlayer.BuildAPlayer(players);
                        Console.WriteLine("");
                        break;                    
                    case "2":
                        PlayGame.Game(players);
                        Console.WriteLine("");
                        break;                    
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine(StandardMessages.MenuError());
                        Console.WriteLine("");
                        break;
                }               
            } while (exit == false);

        }             
             
    }
}
