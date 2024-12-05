using System;
using System.Data.SQLite;
using System.Threading;

namespace CookingSystem
{
    class GameMenu : IMenu
    {
        private CharacterCustomization characterCustomization;
        private CookingCustomization cookingCustomization;
        private ApronCustomization apronCustomization;
        private InteractionCustomization interactionCustomization;

        public void CreateCharacter()
        {
            characterCustomization = new CharacterCustomization();
            characterCustomization.Customize();
            cookingCustomization = new CookingCustomization();
            cookingCustomization.Customize();
            apronCustomization = new ApronCustomization();
            apronCustomization.Customize();
            interactionCustomization = new InteractionCustomization();
            interactionCustomization.Customize();
            Overview.Display(characterCustomization, cookingCustomization, apronCustomization, interactionCustomization);
        }

        public void LoadGame()
        {
        }

        public void CampaignMode()
        {
            Console.Clear();
            Console.WriteLine("══════════════════════════════════════════════════════");
            Console.WriteLine("                     Campaign Mode");
            Console.WriteLine("══════════════════════════════════════════════════════\n");

            try
            {
                if (characterCustomization == null)
                {
                    throw new CharacterNotCreatedException("Please create a character first");
                }

                characterCustomization.CampaignStory();
            }
            catch (CharacterNotCreatedException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }


            Console.WriteLine("\n══════════════════════════════════════════════════════");
            Console.WriteLine("               Press any key to continue...\n");
;
        }

        public void Credits()
        {
            Console.WriteLine("\n══════════════════════════════════════════════════════");
            Console.WriteLine("                        CREDITS                       ");
            Console.WriteLine("══════════════════════════════════════════════════════");
            Console.WriteLine("\nThis game was created by:");
            Console.WriteLine("\nRivera, Luis - Coder: Responsible for implementing the game mechanics and logic.");
            Console.WriteLine("Despabeladero, Alexis - Member: Role yet to be assigned.");
            Console.WriteLine("Crisostomo, Rafael Lorenz - Member: Role yet to be assigned.");
            Console.WriteLine("\nWe all share a love for anime, and we’re still recovering from the fact that we named this game so long it could be its own anime episode title xD\n");
        }

        public void Exit()
        {
            Console.WriteLine("\nThank you for playing, game will exit shortly.");
            Thread.Sleep(1500);
        }
    }

    public class CharacterNotCreatedException : Exception
    {
        public CharacterNotCreatedException(string message) : base(message) { }
    }

}
