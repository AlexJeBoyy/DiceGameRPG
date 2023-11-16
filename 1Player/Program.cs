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

            Console.WriteLine("You are playing single player");
            Console.WriteLine("Do you want to start the game?");
            input = Console.ReadLine();
            input.ToLower();
            if (input == "yes")
            {
                Console.Clear();
                Player1Menu();
            }
            else
            {
                Console.WriteLine("So no games :,(");
            }
            #region player 
            void Player1Menu()//the menu for p1 
            {
                //Console.Clear();
                
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1 : Add resources");
                Console.WriteLine("2 : Look at resources");// more to be added here
                Console.WriteLine("3 : Buy weapons");
                Console.WriteLine("4 : Attack monster");
                input = Console.ReadLine();
                if (input == "1" || input == "2" || input == "3" || input == "4")
                {
                    int menup1 = int.Parse(input);


                    switch (menup1)

                    {
                        case 1:

                            AddResourcesP1();
                            break;
                        case 2:

                            Console.WriteLine("2 option yet to be added");
                            break;
                        case 3:

                            Console.WriteLine("3 option yet to be added");
                            break;

                        default:

                            if (menup1 < 3)
                            {

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("That wasn't a option, please try again");
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
                        Console.WriteLine($"You got {howMuch} wood");
                        wood1 += howMuch;
                        Console.WriteLine($"You now have {wood1} wood");
                        break;
                    case 2:
                        Console.WriteLine($"You got {howMuch} iron");
                        iron1 += howMuch;
                        Console.WriteLine($"You now have {iron1} iron");
                        break;
                    case 3:
                        Console.WriteLine($"You got {howMuch} leather");
                        leather1 += howMuch;
                        Console.WriteLine($"You now have {leather1} leather");
                        break;
                    case 4:
                        Console.WriteLine($"You got {howMuch} stone");
                        stone1 += howMuch;
                        Console.WriteLine($"You now have {stone1} stone");
                        break;
                    case 5:
                        Console.WriteLine($"You got {howMuch} fabric");
                        fabric1 += howMuch;
                        Console.WriteLine($"You now have {fabric1} fabric");
                        break;
                    case 6:
                        Console.WriteLine($"You got {howMuch} rope");
                        rope1 += howMuch;
                        Console.WriteLine($"You now have {rope1} rope");
                        break;
                    case 7:
                        Console.WriteLine($"You got {howMuch} mana");
                        mana1 += howMuch;
                        Console.WriteLine($"You now have {mana1} mana");
                        break;
                }
            }
            void ResourceManagement()
            {

            }
            #endregion
            //void 
        }
    }
}
