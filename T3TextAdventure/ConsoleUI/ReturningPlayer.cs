using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAdventureLib;

namespace ConsoleUI
{
    public class ReturningPlayer
    {
        
        public static bool LoginPlayer(List<Player> inputList)
        {
            StreamReader inputfile;            
            string input,password,name;
            string[] tokens;
            Player thisPlayer = new Player();


            
                try
                {
                    Console.Write(StandardMessages.GetPlayerName());
                    name = Console.ReadLine();
                    inputfile = File.OpenText($@"../../../TextAdventureLib/Players/{name}.csv");
                    input = inputfile.ReadLine();
                    tokens = input.Split(',');
                    Console.Write(StandardMessages.GetPlayerPassword());
                    password = Console.ReadLine();
                    if (password.Equals(tokens[2]))
                    {
                        thisPlayer.Name = tokens[0];
                        thisPlayer.Health = int.Parse(tokens[1]);
                        thisPlayer.Password = tokens[2];
                        thisPlayer.Class = tokens[3];
                        thisPlayer.Race = tokens[4];
                        thisPlayer.Admin = bool.Parse(tokens[5]);
                        inputList.Add(thisPlayer);
                        inputfile.Close();
                    return true;
                    }
                    else
                    {
                        Console.WriteLine(StandardMessages.DisplayPasswordError());
                        return false;
                    }
                    
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(StandardMessages.DisplayReturnPlayerError());
                    return false;
                    
                }         

            
            

        }
    }
}
