using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAdventureLib;

namespace ConsoleUI
{
    public class Create
    {
        public static void CreateMob()
        {
            Mob mob = new Mob();
            bool error = false;
            try
            {
                StreamWriter outputFile = File.AppendText(@"../../../TextAdventureLib/Docs/Monsters.csv");
                Console.Write("Enter the name of the mob: ");
                mob.Name = Console.ReadLine().Trim();
                do
                {
                    Console.Write("Enter the health of the mob: ");
                    mob.Health = ConvertInput.ConvertToInt(Console.ReadLine().Trim());
                    if(mob.Health < 0)
                    {
                        error = true;
                        Console.WriteLine(StandardMessages.DisplayCreaterNumberError());
                    }
                    else
                    {
                        error = false;
                    }
                } while (error == true);
                do
                {
                    Console.Write("Enter the damage of the mob: ");
                    mob.Damage = ConvertInput.ConvertToInt(Console.ReadLine().Trim());
                    if (mob.Damage < 0)
                    {
                        error = true;
                        Console.WriteLine(StandardMessages.DisplayCreaterNumberError());
                    }
                    else
                    {
                        error = false;
                    }
                } while (error == true);

                outputFile.Write($"{mob.Name},{mob.Health},{mob.Damage}");
                outputFile.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

            World.mobs.Add(mob);
            Console.WriteLine("Mob created successfully!");
        }

        public static void CreateItem()
        {
            Item item = new Item();
            try
            {
                StreamWriter outputFile = File.AppendText(@"../../../TextAdventureLib/Docs/Items.csv");
                Console.Write("Enter the name of the item: ");
                item.Name = Console.ReadLine().Trim();
                Console.Write("Enter the description of the item: ");
                item.Description = Console.ReadLine().Trim();

                outputFile.Write($"{item.Name},{item.Description}");
                outputFile.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
            
            World.items.Add(item);
            Console.WriteLine("Item created successfully!");
        }

        public static void CreateTreasure()
        {
            Treasure treasure = new Treasure();
            try
            {
                StreamWriter outputFile = File.AppendText(@"../../../TextAdventureLib/Docs/Treasures.csv");
                Console.Write("Enter the name of the treasuer: ");
                treasure.Name = Console.ReadLine().Trim();
                Console.Write("Enter the description of the treasuer: ");
                treasure.Description = Console.ReadLine().Trim();

                outputFile.Write($"{treasure.Name},{treasure.Description}");
                outputFile.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

            World.treasures.Add(treasure);
            Console.WriteLine("Treasure created successfully!");
        }

        public static void CreatePotion()
        {
            Potion potion = new Potion();
            try
            {
                StreamWriter outputFile = File.AppendText(@"../../../TextAdventureLib/Docs/Potions.csv");
                Console.Write("Enter the name of the potion: ");
                potion.Name = Console.ReadLine().Trim();
                Console.Write("Enter the description of the potion: ");
                potion.Description = Console.ReadLine().Trim();

                outputFile.Write($"{potion.Name},{potion.Description}");
                outputFile.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

            World.potions.Add(potion);
            Console.WriteLine("Potion created successfully!");
        }

        public static void CreateWeapon()
        {
            Weapon weapon = new Weapon();
            bool error = false;
            try
            {
                StreamWriter outputFile = File.AppendText(@"../../../TextAdventureLib/Docs/Weapons.csv");
                Console.Write("Enter the name of the weapon: ");
                weapon.Name = Console.ReadLine().Trim();
                Console.Write("Enter the description of the weapon: ");
                weapon.Description = Console.ReadLine().Trim();
                do
                {
                    Console.Write("Enter the durablitly of the weapon: ");
                    weapon.Durability = ConvertInput.ConvertToInt(Console.ReadLine().Trim());
                    if(weapon.Durability>0)
                    {
                        Console.WriteLine(StandardMessages.DisplayCreaterNumberError());
                        error = true;
                    }
                    else
                    {
                        error = false;
                    }
                } while (error==true);
                do
                {
                    Console.Write("Enter the damage of the weapon: ");
                    weapon.Damage = ConvertInput.ConvertToInt(Console.ReadLine().Trim());
                    if (weapon.Damage > 0)
                    {
                        Console.WriteLine(StandardMessages.DisplayCreaterNumberError());
                        error = true;
                    }
                    else
                    {
                        error = false;
                    }
                } while (error==true);

                outputFile.Write($"{weapon.Name},{weapon.Description},{weapon.Durability},{weapon.Damage}");
                outputFile.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

            World.weapons.Add(weapon);
            Console.WriteLine("Weapon created successfully!");
        }
    }
}
