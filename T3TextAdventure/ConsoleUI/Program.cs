﻿/**
* Start Date - 9/6/20
* Updated on - 10/11/20
* CSC-253
* Team 3
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
            bool exit = false,loginSuccess;
            List<Player> players = new List<Player>();

            


            do
            {
                Console.WriteLine(StandardMessages.Menu());


                switch (Console.ReadLine())
                {
                    case "1":
                        BuildPlayer.BuildAPlayer(players);
                        PlayGame.Game(players);
                        Console.WriteLine("");
                        break;
                    case "2":
                        loginSuccess = ReturningPlayer.LoginPlayer(players);
                        
                        if(loginSuccess==true)
                        {
                            PlayGame.Game(players);
                        }                        
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
