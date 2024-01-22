using System;

namespace Assets.CharacterCreator2D.Creator_UI.Scripts.Textual_Generator.TextualDecorator
{
    public class FemaleDecorator : TextualModelDecorator
    {
        public FemaleDecorator(ITextualModel textualModel) : base(textualModel) { 
            Console.WriteLine("Female Decorator");
        }

        public new bool Design()
        {
            TextualModel.Design();
            SetAdditional();
            return false;
        }

        public void SetAdditional ()
        {
            Console.WriteLine("Additional Set");
        }
    }
}
