using CookingSystem;

namespace CookingSystem
{

    class CharacterCustomization : Customization
    {

        private string _characName;
        private string _gender;
        private string _age;
        private string _skinTone;
        private string _height;
        private string _bodyType;
        private string _hairTexture;
        private string _hairStyle;
        private string _hairColor;
        private string _eyeColor;
        private string _outfitStyle;
        private bool _hasTattoo;
        private bool _hasGlasses;

        public CharacterCustomization()
        {
            _characName = "Default Name";
            _gender = "Male";
            _age = "Adult";
            _skinTone = "Fair";
            _height = "Average";
            _bodyType = "Slim";
            _hairTexture = "Wavy";
            _hairStyle = "Short";
            _hairColor = "Black";
            _eyeColor = "Brown";
            _outfitStyle = "Casual";
            _hasTattoo = false;
            _hasGlasses = false;
        }

        public string CharacName
        {
            get { return _characName; }
            set { _characName = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string SkinTone
        {
            get { return _skinTone; }
            set { _skinTone = value; }
        }

        public string Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public string BodyType
        {
            get { return _bodyType; }
            set { _bodyType = value; }
        }

        public string HairTexture
        {
            get { return _hairTexture; }
            set { _hairTexture = value; }
        }

        public string HairStyle
        {
            get { return _hairStyle; }
            set { _hairStyle = value; }
        }

        public string HairColor
        {
            get { return _hairColor; }
            set { _hairColor = value; }
        }

        public string EyeColor
        {
            get { return _eyeColor; }
            set { _eyeColor = value; }
        }

        public string OutfitStyle
        {
            get { return _outfitStyle; }
            set { _outfitStyle = value; }
        }

        public bool HasTattoo
        {
            get { return _hasTattoo; }
            set { _hasTattoo = value; }
        }

        public bool HasGlasses
        {
            get { return _hasGlasses; }
            set { _hasGlasses = value; }
        }


        public override void Customize()
        {
            Console.WriteLine("\n══════════════════════════════════════════════════════");
            Console.WriteLine("               Customize your character!              ");
            Console.WriteLine("══════════════════════════════════════════════════════\n");

            CharacName = ChooseUser("Enter your character's username:");
            Gender = ChooseOption("Please select your gender", new Dictionary<int, string>
            {
                { 1, "Male" },
                { 2, "Female" },
                { 3, "Non-Binary" },
                { 4, "Prefer not to say" }
            });
            Age = ChooseOption("Please select your age category", new Dictionary<int, string>
            {
                { 1, "Young" },
                { 2, "Adult" },
                { 3, "Middle-Aged" },
                { 4, "Senior" }
            });
            SkinTone = ChooseOption("Please select your skin tone", new Dictionary<int, string>
            {
                { 1, "Fair" },
                { 2, "Light" },
                { 3, "Medium" },
                { 4, "Tan" },
                { 5, "Dark" }
            });
            Height = ChooseOption("Please select your height category", new Dictionary<int, string>
            {
                { 1, "Short" },
                { 2, "Average" },
                { 3, "Tall" },
                { 4, "Very Tall" },
                { 5, "Petite" }
            });
            BodyType = ChooseOption("Please select a body type", new Dictionary<int, string>
            {
                { 1, "Slim" },
                { 2, "Athletic" },
                { 3, "Curvy" },
                { 4, "Stocky" }
            });
            HairTexture = ChooseOption("Please select your hair texture", new Dictionary<int, string>
            {
                { 1, "Wavy" },
                { 2, "Curly" },
                { 3, "Coiled" },
                { 4, "Straight" }
            });
            HairStyle = ChooseOption("Please select your hair style", new Dictionary<int, string>
            {
                { 1, "Long" },
                { 2, "Short" },
                { 3, "Ponytail" },
                { 4, "Buzz Cut" }
            });
            HairColor = ChooseOption("Please select your hair color", new Dictionary<int, string>
            {
                { 1, "Black" },
                { 2, "Brown" },
                { 3, "Blonde" },
                { 4, "Red" }
            });
            EyeColor = ChooseOption("Please select your eye color", new Dictionary<int, string>
            {
                { 1, "Black" },
                { 2, "Brown" },
                { 3, "Blue" },
                { 4, "Green" },
                { 5, "Hazel" }
            });
            OutfitStyle = ChooseOption("Please select an outfit style", new Dictionary<int, string>
            {
                { 1, "Chef Uniform" },
                { 2, "Casual Apron" },
                { 3, "Formal Suit" },
                { 4, "Athletic Wear" }
            });
            HasTattoo = ChooseFlag("Does your character have tattoos?", new Dictionary<int, bool>
            {
                { 1, false },
                { 2, true }
            });
            HasGlasses = ChooseFlag("Does your character wear glasses?", new Dictionary<int, bool>
            {
                { 1, true },
                { 2, false }
            });
        }

        public void CampaignStory()
        {
            string[] story = new string[]
            {
                "My name is " + CharacName + ", and I am just a home cook.",
                "I enjoy making food for my partner after their long workdays,",
                "and every meal I cook for them, they always enjoy.",
                "They always compliment me, saying I should be a chef for being good at cooking.",
                "\nBut one night, while frying the chicken, a bright light suddenly filled the kitchen.",
                "Before I knew it, I was taken away and woke up in a strange cage with many other chefs.",
                "They looked serious and said they were famous, but I didn’t understand why I was there with them.",
                "\nLater, we were taken to a large room, and a person called the greatest chef in the world explained why we had been chosen.",
                "They said the world was in danger because of hungry gods.",
                "If they didn’t get the best food, they would destroy everything.",
                "The chefs were supposed to make dishes so amazing that the gods would be happy.",
                "I was confused because I wasn’t a great chef like the others. I just cooked for my partner at home.",
                "\nThen, a stranger looked at me and said, “You are the one who can save us.”",
                "I was shocked and didn’t know what they meant.",
                "They said that my cooking skills were special and could reach the hearts of the gods.",
                "I didn’t believe them at first; I doubted every single word they said because I was just a chill person who cooks for my partner.",
                "But something inside me said I had to try.",
                "If my cooking could save the world, I would have to do my best, even if I were just a simple, chill home cook."
            };

            foreach (var line in story)
            {
                Console.WriteLine(line);
            }
        }
    }
}