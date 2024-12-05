using System;
using System.Threading;

namespace CookingSystem
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            CharacterCustomization characterCustomization = new CharacterCustomization();
            GameMenu game = new GameMenu();

            bool gameRunning = false;

            while (!gameRunning)
            {

                Console.WriteLine("══════════════════════════════════════════════════════");
                Console.WriteLine("       I Was Just a Home Cook, but Now I’m in a   ");
                Console.WriteLine("     Shokugeki Battleground Where the Fate of the  ");
                Console.WriteLine("           World Rests on My Signature Dish!       ");
                Console.WriteLine("══════════════════════════════════════════════════════\n");

                Console.WriteLine("Please select an option: ");

                Console.WriteLine("[1] Sharpen Your Knives (New Game)");
                Console.WriteLine("[2] Reheat the Leftovers (Load Game)");
                Console.WriteLine("[3] Whisk Into Action (Campaign Mode)");
                Console.WriteLine("[4] Meet the Master Chefs (Credits)");
                Console.WriteLine("[5] Close the Kitchen (Exit)");

                int userChoice = 0;
                bool validChoice = false;

                while (!validChoice)
                {
                    try
                    {
                        userChoice = Convert.ToInt32(Console.ReadLine());
                        if (userChoice >= 1 && userChoice <= 5)
                        {
                            validChoice = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice, please choose a number between 1 and 5.");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input! Please enter a valid number.");
                    }
                }

                switch (userChoice)
                {
                    case 1:
                        game.CreateCharacter();
                        break;
                    case 2:
                        game.LoadGame();
                        break;
                    case 3:
                        game.CampaignMode();
                        break;
                    case 4:
                        game.Credits();
                        break;
                    case 5:
                        game.Exit();
                        gameRunning  = true;
                        return;
                }

                Console.WriteLine("Go back to main menu?\n[1] Yes\n[2] No");
                int userChoice2 = 0;
                validChoice = false;

                while (!validChoice)
                {
                    try
                    {
                        userChoice2 = Convert.ToInt32(Console.ReadLine());
                        if (userChoice2 == 1 || userChoice2 == 2)
                        {
                            validChoice = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice, please choose 1 or 2.");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input! Please enter a valid number.");
                    }
                }

                if (userChoice2 == 2)
                {
                    gameRunning = true;
                    Console.WriteLine("Exiting game...");
                }
            }

            Console.ReadKey();
        }
    }
}
