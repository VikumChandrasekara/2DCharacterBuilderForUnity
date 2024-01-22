using Assets.CharacterCreator2D.Creator_UI.Scripts.Textual_Generator.Models;
using Assets.CharacterCreator2D.Creator_UI.Scripts.Textual_Generator.Utils;
using System;
using UnityEngine;

namespace Assets.CharacterCreator2D.Creator_UI.Scripts.Textual_Generator.TextualDecorator
{
    class ModelDecoratorDemo : MonoBehaviour
    {
        static string defaultMalePath = "Assets/TestCharacters/DefaultMale.json";

        public static String GetJSONFromSpecification()
        {
            string  st = FileReader.ReadData(defaultMalePath);
            return st;
        }

        public static String Decorate(Specification specification)
        {
            if (specification != null && 
                specification.Gender == (int)Enums.GenderType.Female)
            {
                // Female default
                ITextualModel longHairFemaleModel = new FemaleDecorator(new FemaleTextualModel());
                longHairFemaleModel.Design();
                return "Female";
            }
            else
            {
                // Male default
                ITextualModel longHairMaleModel = new MaleDecorator(new MaleTextualModel());
                longHairMaleModel.Design();
                string defaultMalePath = "Assets/TestCharacters/DefaultMale.json";
                return "Assets/TestCharacters/DefaultMale.json";
            }
        }
    }
}
