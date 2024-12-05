using System;
using System.Text.RegularExpressions;

namespace CookingSystem
{
    abstract class Customization 
    {
        public abstract void Customize();
        
        public string ChooseUser(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Validator.GetValidatedUser();
            return input;
        }


        public string ChooseOption(string prompt, Dictionary<int, string> options)
        {
            Console.WriteLine("\n" + prompt);
            foreach (var option in options)
            {
                Console.WriteLine("[" + option.Key + "] " + option.Value);
            }

            int choice = Validator.GetValidatedInput(1, options.Count);
            return options[choice];
        }

        public bool ChooseFlag(string prompt, Dictionary<int, bool> options)
        {
            Console.WriteLine("\n" + prompt);
            foreach (var option in options)
            {
                Console.WriteLine("[" + option.Key + "] " + (option.Value ? "Yes" : "No"));
            }

            int choice = Validator.GetValidatedInput(1, options.Count);
            return options[choice];
        }
    }
}
