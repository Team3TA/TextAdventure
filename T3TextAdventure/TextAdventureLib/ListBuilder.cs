using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureLib
{
    public class ListBuilder
    {
        public static void BuildMonsterList()
        {
            StreamReader inputFile = File.OpenText(@"../../../TextAdventureLib/Docs/Monsters.csv");
            string input;
            string[] tokens;

            while(!inputFile.EndOfStream)
            {


                input = inputFile.ReadLine();
                tokens = input.Split(',');

                World.mobs.Add(new Mob(tokens[0], int.Parse(tokens[1]), int.Parse(tokens[2])));

            }

            inputFile.Close();
        }

        public static void BuildItemList()
        {
            StreamReader inputFile = File.OpenText(@"../../../TextAdventureLib/Docs/Items.csv");
            string input;
            string[] tokens;

            while (!inputFile.EndOfStream)
            {


                input = inputFile.ReadLine();
                tokens = input.Split(',');

                World.items.Add(new Item(tokens[0],tokens[1]));

            }

            inputFile.Close();

        }

        public static void BuildWeaponList()
        {
            StreamReader inputFile = File.OpenText(@"../../../TextAdventureLib/Docs/Weapons.csv");
            string input;
            string[] tokens;

            while (!inputFile.EndOfStream)
            {


                input = inputFile.ReadLine();
                tokens = input.Split(',');

                World.weapons.Add(new Weapon(tokens[0],tokens[1],int.Parse(tokens[2]),int.Parse(tokens[3])));

            }

            inputFile.Close();

        }

        public static void BuildPotionList()
        {
            StreamReader inputFile = File.OpenText(@"../../../TextAdventureLib/Docs/Potions.csv");
            string input;
            string[] tokens;

            while (!inputFile.EndOfStream)
            {


                input = inputFile.ReadLine();
                tokens = input.Split(',');

                World.potions.Add(new Potion(tokens[0],tokens[1]));

            }

            inputFile.Close();

        }

        public static void BuildTreasureList()
        {
            StreamReader inputFile = File.OpenText(@"../../../TextAdventureLib/Docs/Treasures.csv");
            string input;
            string[] tokens;

            while (!inputFile.EndOfStream)
            {


                input = inputFile.ReadLine();
                tokens = input.Split(',');

                World.treasures.Add(new Treasure(tokens[0], tokens[1]));

            }

            inputFile.Close();

        }

        
    }
}
