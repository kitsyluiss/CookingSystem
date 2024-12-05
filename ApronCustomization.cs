using System;
using System.Collections.Generic;

namespace CookingSystem
{
    class ApronCustomization : Customization
    {
        private string _apronStyle;
        private string _apronColor;
        private string _apronPattern;

        public ApronCustomization()
        {
            _apronStyle = "Classic";
            _apronColor = "White";
            _apronPattern = "Solid";
        }

        public ApronCustomization(string apronStyle, string apronColor, string apronPattern)
        {
            _apronStyle = apronStyle;
            _apronColor = apronColor;
            _apronPattern = apronPattern;
        }

        public string ApronStyle
        {
            get => _apronStyle;
            set => _apronStyle = value;
        }

        public string ApronColor
        {
            get => _apronColor;
            set => _apronColor = value;
        }

        public string ApronPattern
        {
            get => _apronPattern;
            set => _apronPattern = value;
        }

        public override void Customize()
        {
            Console.WriteLine("\n══════════════════════════════════════════════════════");
            Console.WriteLine("                 Customize your apron!                ");
            Console.WriteLine("══════════════════════════════════════════════════════\n");

            ApronStyle = ChooseOption("What style of apron does your character wear?", new Dictionary<int, string>
            {
                { 1, "Classic" },
                { 2, "Bib" },
                { 3, "Waist" },
                { 4, "Pinafore" },
                { 5, "Apron Dress" }
            });

            ApronColor = ChooseOption("What color is your character’s apron?", new Dictionary<int, string>
            {
                { 1, "White" },
                { 2, "Black" },
                { 3, "Red" },
                { 4, "Blue" },
                { 5, "Green" }
            });

            ApronPattern = ChooseOption("What pattern is on your character’s apron?", new Dictionary<int, string>
            {
                { 1, "Solid" },
                { 2, "Stripes" },
                { 3, "Checkered" },
                { 4, "Floral" },
                { 5, "Graphic" }
            });
        }
    }
}
