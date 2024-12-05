using System;

namespace CookingSystem
{
    class CookingCustomization : Customization
    {
        private string _cookingStyle;
        private string _cookingExperience;
        private string _homeland;
        private string _cuisineStyle;
        private string _specialty;
        private string _favoriteIngredients;
        private string _personality;
        private string _voiceType;
        private string _cookingTool;
        private string _mood;


        public string CookingStyle
        {
            get => _cookingStyle;
            set => _cookingStyle = value;
        }

        public string CookingExperience
        {
            get => _cookingExperience;
            set => _cookingExperience = value;
        }

        public string Homeland
        {
            get => _homeland;
            set => _homeland = value;
        }

        public string CuisineStyle
        {
            get => _cuisineStyle;
            set => _cuisineStyle = value;
        }

        public string Specialty
        {
            get => _specialty;
            set => _specialty = value;
        }

        public string FavoriteIngredients
        {
            get => _favoriteIngredients;
            set => _favoriteIngredients = value;
        }

        public string Personality
        {
            get => _personality;
            set => _personality = value;
        }

        public string VoiceType
        {
            get => _voiceType;
            set => _voiceType = value;
        }

        public string CookingTool
        {
            get => _cookingTool;
            set => _cookingTool = value;
        }

        public string Mood
        {
            get => _mood;
            set => _mood = value;
        }

        public override void Customize()
        {
            Console.WriteLine("\n══════════════════════════════════════════════════════");
            Console.WriteLine("                Customize your cooking!               ");
            Console.WriteLine("══════════════════════════════════════════════════════\n");

            CookingStyle = ChooseOption("Please select your cooking style", new Dictionary<int, string>
            {
                { 1, "Precise" },
                { 2, "Messy" },
                { 3, "Artistic" }
            });

            CookingExperience = ChooseOption("What is your cooking experience level?", new Dictionary<int, string>
            {
                { 1, "Beginner" },
                { 2, "Intermediate" },
                { 3, "Master" }
            });

            Homeland = ChooseOption("Where is your character from?", new Dictionary<int, string>
            {
                { 1, "Italy" },
                { 2, "Japan" },
                { 3, "Mexico" },
                { 4, "France" },
                { 5, "India" }
            });

            CuisineStyle = ChooseOption("What type of food does your character like to cook?", new Dictionary<int, string>
            {
                { 1, "Asian" },
                { 2, "Mediterranean" },
                { 3, "French" },
                { 4, "Latin American" },
                { 5, "Fusion" }
            });

            Specialty = ChooseOption("What is your character really good at cooking?", new Dictionary<int, string>
            {
                { 1, "Sushi" },
                { 2, "BBQ" },
                { 3, "Pasta" },
                { 4, "Pastries" },
                { 5, "Stews" }
            });

            FavoriteIngredients = ChooseOption("What ingredients does your character like to use the most?", new Dictionary<int, string>
            {
                { 1, "Spices" },
                { 2, "Fresh Herbs" },
                { 3, "Seafood" },
                { 4, "Meats" },
                { 5, "Vegetables" }
            });

            Personality = ChooseOption("What is your character’s personality in the kitchen?", new Dictionary<int, string>
            {
                { 1, "Perfectionist" },
                { 2, "Creative" },
                { 3, "Competitive" },
                { 4, "Humorous" },
                { 5, "Calm" }
            });

            VoiceType = ChooseOption("What type of voice does your character have?", new Dictionary<int, string>
            {
                { 1, "Calm" },
                { 2, "Energetic" },
                { 3, "Quirky" },
                { 4, "Deep" },
                { 5, "Soft" }
            });

            CookingTool = ChooseOption("What is your character's preferred cooking tool?", new Dictionary<int, string>
            {
                { 1, "Knife" },
                { 2, "Whisk" },
                { 3, "Wok" },
                { 4, "Rolling Pin" },
                { 5, "Grill" }
            });

            Mood = ChooseOption("How does your character feel while cooking?", new Dictionary<int, string>
            {
                { 1, "Relaxed" },
                { 2, "Energetic" },
                { 3, "Focused" },
                { 4, "Excited" },
                { 5, "Frustrated" }
            });
        }
    }
}
