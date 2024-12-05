using System;

namespace CookingSystem
{
    class Overview
    {
        public static void Display(CharacterCustomization characterCustomization,
                                   CookingCustomization cookingCustomization,
                                   ApronCustomization apronCustomization,
                                   InteractionCustomization interactionCustomization)
        {
            Console.WriteLine("\nCongrats! You have successfully created a character!\n");

            Console.WriteLine("═══════ Character Attributes ═══════");
            Console.WriteLine("Character Name: " + characterCustomization.CharacName);
            Console.WriteLine("Gender: " + characterCustomization.Gender);
            Console.WriteLine("Age: " + characterCustomization.Age);
            Console.WriteLine("Skin Tone: " + characterCustomization.SkinTone);
            Console.WriteLine("Height: " + characterCustomization.Height);
            Console.WriteLine("Body Type: " + characterCustomization.BodyType);
            Console.WriteLine("Hair Texture: " + characterCustomization.HairTexture);
            Console.WriteLine("Hair Style: " + characterCustomization.HairStyle);
            Console.WriteLine("Hair Color: " + characterCustomization.HairColor);
            Console.WriteLine("Eye Color: " + characterCustomization.EyeColor);
            Console.WriteLine("Outfit Style: " + characterCustomization.OutfitStyle);
            Console.WriteLine("Has Tattoo: " + characterCustomization.HasTattoo);
            Console.WriteLine("Has Glasses: " + characterCustomization.HasGlasses);

            Console.WriteLine("\n═══════ Cooking Customization ═══════");
            Console.WriteLine("Cooking Style: " + cookingCustomization.CookingStyle);
            Console.WriteLine("Cooking Experience: " + cookingCustomization.CookingExperience);
            Console.WriteLine("Homeland: " + cookingCustomization.Homeland);
            Console.WriteLine("Cuisine Style: " + cookingCustomization.CuisineStyle);
            Console.WriteLine("Specialty: " + cookingCustomization.Specialty);
            Console.WriteLine("Favorite Ingredients: " + cookingCustomization.FavoriteIngredients);
            Console.WriteLine("Personality: " + cookingCustomization.Personality);
            Console.WriteLine("Voice Type: " + cookingCustomization.VoiceType);
            Console.WriteLine("Cooking Tool: " + cookingCustomization.CookingTool);
            Console.WriteLine("Mood: " + cookingCustomization.Mood);

            Console.WriteLine("\n═══════ Apron Customization ═══════");
            Console.WriteLine("Apron Style: " + apronCustomization.ApronStyle);
            Console.WriteLine("Apron Color: " + apronCustomization.ApronColor);
            Console.WriteLine("Apron Pattern: " + apronCustomization.ApronPattern);

            Console.WriteLine("\n═══════ Interaction Customization ═══════");
            Console.WriteLine("Voice Lines: " + interactionCustomization.VoiceLines);
            Console.WriteLine("Signature Gesture: " + interactionCustomization.SignatureGesture);
            Console.WriteLine("Culinary Partner: " + interactionCustomization.CulinaryPartner);
            Console.WriteLine("Theme Music: " + interactionCustomization.ThemeMusic);

            Console.WriteLine("\nCharacter customization complete!\n");
        }
    }
}
