using System;
using System.Collections.Generic;

namespace CookingSystem
{
    class InteractionCustomization : Customization
    {
        private string _voiceLines;
        private string _signatureGesture;
        private string _culinaryPartner;
        private string _themeMusic;

        public InteractionCustomization()
        {
            _voiceLines = "Motivational Quotes";
            _signatureGesture = "Thumbs-Up";
            _culinaryPartner = "Cat";
            _themeMusic = "Classical";
        }

        public InteractionCustomization(string voiceLines, string signatureGesture, string culinaryPartner, string themeMusic)
        {
            _voiceLines = voiceLines;
            _signatureGesture = signatureGesture;
            _culinaryPartner = culinaryPartner;
            _themeMusic = themeMusic;
        }

        public string VoiceLines
        {
            get => _voiceLines;
            set => _voiceLines = value;
        }

        public string SignatureGesture
        {
            get => _signatureGesture;
            set => _signatureGesture = value;
        }

        public string CulinaryPartner
        {
            get => _culinaryPartner;
            set => _culinaryPartner = value;
        }

        public string ThemeMusic
        {
            get => _themeMusic;
            set => _themeMusic = value;
        }

        public override void Customize()
        {
            Console.WriteLine("\n══════════════════════════════════════════════════════");
            Console.WriteLine("              Customize your interaction!             ");
            Console.WriteLine("══════════════════════════════════════════════════════\n");

            VoiceLines = ChooseOption("Please select your character's voice line expression", new Dictionary<int, string>
            {
                { 1, "Motivational Quotes" },
                { 2, "Funny Puns" },
                { 3, "Professional Commands" },
                { 4, "Excited Cheers" },
                { 5, "Calm Remarks" }
            });

            SignatureGesture = ChooseOption("Please select your signature gesture", new Dictionary<int, string>
            {
                { 1, "Thumbs-Up" },
                { 2, "Chef's Kiss" },
                { 3, "Victory Pose" },
                { 4, "Salute" },
                { 5, "Wink" }
            });

            CulinaryPartner = ChooseOption("Please select your culinary partner/pet companion", new Dictionary<int, string>
            {
                { 1, "Cat" },
                { 2, "Dog" },
                { 3, "Robot" },
                { 4, "Parrot" },
                { 5, "None" }
            });

            ThemeMusic = ChooseOption("Please select your theme music", new Dictionary<int, string>
            {
                { 1, "Classical" },
                { 2, "Jazzy" },
                { 3, "Upbeat" },
                { 4, "Lo-Fi Beats" },
                { 5, "Rock" }
            });
        }
    }
}
