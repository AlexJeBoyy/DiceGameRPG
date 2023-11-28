using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*What do i still need to do
            * - player can look at their resources
            * - Player can buy weapons
            * - Player can look at their weapons
            * - Player can Attack monster
            * - Monsters exist
            * - if monster is defeated either next monster starts or player wins
            * - 
            * 
            * 
            * 
            */











            string input;//you can use this to get input for console read

            //player 1 resources
            int wood1 = 0;
            int iron1 = 0;
            int leather1 = 0;
            int stone1 = 0;
            int fabric1 = 0;
            int rope1 = 0;
            int mana1 = 0;

            int sword = 0;
            int axe = 0;
            int bow = 0;

            /*monsters
             * 
             * Dragon (final boss) has 50hp
             * goblin (2) 25hp
             * Skeleton (3) 15hp
             */

            //Console.WriteLine("You are playing single player");
            //Console.WriteLine("Do you want to start the game?");
            //input = Console.ReadLine();
            //input.ToLower();
            //if (input == "yes")
            //{
            //    Console.Clear();
            //    Player1Menu();
            //}
            //else
            //{
            //    Console.WriteLine("So no games :,(");
            //}

            #region player 
            Player1Menu();
            void Player1Menu()//the menu for p1 
            {
                Console.Clear();

                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1 : Add resources");
                Console.WriteLine("2 : Look at resources");// more to be added here
                Console.WriteLine("3 : Buy weapons");
                Console.WriteLine("4 : Look at weapons");
                Console.WriteLine("5 : Attack monster");
                Console.WriteLine("6 : Quit game");
                input = Console.ReadLine();
                if (int.TryParse(input, out int menup1) == true)
                {
                    switch (menup1)

                    {
                        case 1:

                            AddResourcesP1();
                            break;
                        case 2:

                            ResourceManagement();
                            break;
                        case 3:
                            Console.Clear();
                            WeaponStore();
                            break;
                        case 4:
                            WeaponLook();
                            break;
                        case 5:
                            Console.WriteLine("4 option yet to be added");
                            break;
                        case 6:
                            Console.WriteLine("Bye Bye :)");
                            break;
                        default:

                            if (menup1 < 7) { }
                            else
                            {
                                Console.Clear();
                                Player1Menu();
                            }
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("That wasn't a option, please try again");
                    Player1Menu();
                }
            }
            void AddResourcesP1()
            {
                Console.Clear();
                int whatItem = new Random().Next(1, 8);
                int howMuch = new Random().Next(1, 7);
                switch (whatItem)//different kind of what if used by int
                {
                    //default; will always do it
                    case 1:
                        Console.WriteLine($"+ {howMuch} wood");
                        wood1 += howMuch;
                        Console.WriteLine($"Total: {wood1} wood");
                        break;
                    case 2:
                        Console.WriteLine($"+ {howMuch} iron");
                        iron1 += howMuch;
                        Console.WriteLine($"Total: {iron1} iron");
                        break;
                    case 3:
                        Console.WriteLine($"+ {howMuch} leather");
                        leather1 += howMuch;
                        Console.WriteLine($"Total: {leather1} leather");
                        break;
                    case 4:
                        Console.WriteLine($"+ {howMuch} stone");
                        stone1 += howMuch;
                        Console.WriteLine($"Total: {stone1} stone");
                        break;
                    case 5:
                        Console.WriteLine($"+ {howMuch} fabric");
                        fabric1 += howMuch;
                        Console.WriteLine($"Total: {fabric1} fabric");
                        break;
                    case 6:
                        Console.WriteLine($"+ {howMuch} rope");
                        rope1 += howMuch;
                        Console.WriteLine($"Total: {rope1} rope");
                        break;
                    case 7:
                        Console.WriteLine($"+ {howMuch} mana");
                        mana1 += howMuch;
                        Console.WriteLine($"Total: {mana1} mana");
                        break;
                }

                Console.WriteLine("Type anything to go back.");
                Console.WriteLine();
                input = Console.ReadLine();
                if (input == "1")
                {
                    Player1Menu();
                }
                else
                {
                    Player1Menu();
                }


            }
            void ResourceManagement()
            {
                Console.Clear();
                Console.WriteLine($"wood: {wood1}");
                Console.WriteLine($"iron: {iron1}");
                Console.WriteLine($"leather: {leather1}");
                Console.WriteLine($"stone: {stone1}");
                Console.WriteLine($"fabric: {fabric1}");
                Console.WriteLine($"rope: {rope1}");
                Console.WriteLine($"mana: {mana1}");
                Console.WriteLine();
                Console.WriteLine("Type anything to go back.");
                input = Console.ReadLine();
                if (input == "1")
                {
                    Player1Menu();
                }
                else
                {
                    Player1Menu();
                }
            }
            #endregion
            void WeaponStore()
            {


                Console.WriteLine("Welcome to the weapon store,");
                Console.WriteLine("you can buy weapons here from your resources.");
                Console.WriteLine();
                Console.WriteLine("1 : Sword, iron: 5 leather: 3");
                Console.WriteLine("2 : Axe");
                Console.WriteLine("3 : Bow");

                Console.WriteLine("6 : Back");


                input = Console.ReadLine();
                if (int.TryParse(input, out int menup1) == true)
                {
                    if (input == "1" && iron1 > 4 && leather1 > 2)
                    {
                        Console.Clear();
                        Console.WriteLine("You bought a sword");
                        Console.WriteLine();
                        Player1Menu();

                    }
                    else if (input == "6")
                    {
                        Player1Menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You are unable to do that");
                        WeaponStore();
                    }
                }
                else
                {
                    WeaponStore();
                }


                void WeaponLook()
                {
                    Console.WriteLine("Hello player, you have:");
                    Console.WriteLine($"{sword} swords");
                    Console.WriteLine($"{axe}");

                    Console.WriteLine("1 : Back");


                    input = Console.ReadLine();
                    if (input == "1")
                    {
                        Console.Clear();
                        Player1Menu();
                    }
                }

            }

        }
    }
}
