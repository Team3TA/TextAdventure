using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAdventureLib;

namespace ConsoleUI
{
    class PlayGame
    {
        public static void Game(List<Player> players)
        {
            bool exit = false;
            Room[,] rooms = new Room[5, 3]
                {
                 { new Room("Entrance", "Dungeon entrance"),new Room("Goblin floor", "First floor of the dungeon, a lot of goblins reside here"),new Room("Stairs", "A set of stairs that seem to go deeper into the dungeon") },
                 { new Room("Stairs", "A set of stairs that seem to go deeper into the dungeon"),new Room("Passageway", "No monsters appear, this seems to connect to another area"),new Room("Slime floor", "Second floor of the dungeon, a lot of slimes reside here") },
                 { new Room("Zombie land", "A foggy room with zombies roaming around"),new Room("Passageway", "No monsters appear, this seems to connect to another area"),new Room("Stairs", "A set of stairs that seem to go deeper into the dungeon") },
                 { new Room("Stairs", "A set of stairs that seem to go deeper into the dungeon"),new Room("Passageway", "No monsters appear, this seems to connect to another area"),new Room("Plains", "A vast plains has appeared, it is rumored to be home of the Dire Wolfs") },
                 { new Room("Safe zone", "There are no monsters here. There is a well in the middle of the room"),new Room("Passageway", "No monsters appear, this seems to connect to another area"),new Room("Boss Room", "The final room in the dungeon") }
                };
            Weapon[] weapons = { new Weapon("Dagger", "small dagger", 100, 5), new Weapon("Long Sword", "Long Sword about 3ft long", 100, 15), new Weapon("Scythe", "A long blade used for cutting grasss", 100, 8), new Weapon("Great Sword", "Sword with extra power", 100, 30) };
            Potion[] potions = { new Potion("Vitality Potion", "Recovers health"), new Potion("Mind Potion", "Recovers mana") };
            Treasure[] treasures = { new Treasure("Emerald", "Shiny green emarald"), new Treasure("Diamond", null), new Treasure("Ruby", null) };
            List<Item> items = new List<Item>();
            List<Mob> mobs = new List<Mob>();
            String input;
            int positionV = 0, positionH = 0;
            items.Add(new Item("Key", null));
            items.Add(new Item("Lock Pick", null));
            items.Add(new Item("Whetstone", null));
            items.Add(new Item("Smoke Bomb", null));
            mobs.Add(new Mob("Slime", 30, 2));
            mobs.Add(new Mob("Dire Wolf", 50, 5));
            mobs.Add(new Mob("Goblin", 80, 10));
            mobs.Add(new Mob("Witch", 100, 15));
            mobs.Add(new Mob("Zombie", 15, 30));

            Console.WriteLine(StandardMessages.GameWelcome());
            do
            {

                input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "go north":
                        MoveNorth(ref positionV, ref positionH, rooms);
                        Console.WriteLine("");
                        break;
                    case "go south":
                        MoveSouth(ref positionV, ref positionH, rooms);
                        Console.WriteLine("");
                        break;
                    case "go east":
                        MoveEast(ref positionV, ref positionH, rooms);
                        Console.WriteLine("");
                        break;
                    case "go west":
                        MoveWest(ref positionV, ref positionH, rooms);
                        Console.WriteLine("");
                        break;
                    case "attack":
                        Attack(players[0], mobs[2]);
                        Console.WriteLine("");
                        break;
                    case "exit":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine(StandardMessages.GameError());
                        Console.WriteLine("");
                        break;
                }
            } while (exit == false);

        }
        public static void MoveNorth(ref int positionV, ref int positionH, Room[,] rooms)
        {
            //TODO Fix code to move north
            if ((positionV == 1 && positionH == 2) || (positionV == 2 && positionH == 0) || (positionV == 3 && positionH == 2) || (positionV == 4 && positionH == 0))
            {
                positionV = positionV - 1;
                Console.WriteLine(StandardMessages.RoomMove() + rooms[positionV, positionH].Name);

            }
            else
            {
                Console.WriteLine("You aren't near any stairs and cannot go up to the next floor.");
            }
        }

        public static void MoveSouth(ref int positionV, ref int positionH, Room[,] rooms)
        {
            //TODO Fix code to  move south
            if ((positionV == 0 && positionH == 2) || (positionV == 1 && positionH == 0) || (positionV == 2 && positionH == 2) || (positionV == 3 && positionH == 0))
            {
                positionV++;
                Console.WriteLine(StandardMessages.RoomMove() + rooms[positionV, positionH].Name);
            }
            else
            {
                Console.WriteLine("You aren't near any stairs and cannot go down to the next floor.");
            }

        }
        public static void MoveEast(ref int positionV, ref int positionH, Room[,] rooms)
        {
            //TODO Fix code to move east
            if (positionH != 2)
            {
                positionH++;
                Console.WriteLine(StandardMessages.RoomMove() + rooms[positionV, positionH].Name);
            }
            else
            {
                Console.WriteLine("You can't move further east.");
            }

        }
        public static void MoveWest(ref int positionV, ref int positionH, Room[,] rooms)
        {
            //TODO Fix code to move west
            if (positionH != 0)
            {
                positionH = positionH - 1;
                Console.WriteLine(StandardMessages.RoomMove() + rooms[positionV, positionH].Name); ;
            }
            else
            {
                Console.WriteLine("You can't move further west.");
            }

        }

        public static void Attack(Player yourPlayer, Mob monster)
        {
            Random random = new Random();
            int monsterAttack = random.Next(1, monster.Damage) + 1;
            int playerAttack = random.Next(1, 21);
            yourPlayer.Health = yourPlayer.Health - monsterAttack;
            monster.Health = monster.Health - playerAttack;

            Console.WriteLine($"You attack a {monster.Name} for {playerAttack} leaving it with {monster.Health} health left." +
                $"\nThe {monster.Name} attacks you for {monsterAttack} leaving you with {yourPlayer.Health} health left.");


        }
    }
}
