using System;

namespace Assets.CharacterCreator2D.Creator_UI.Scripts.Textual_Generator.TextualDecorator
{
    public class MaleDecorator : TextualModelDecorator
    {
        public MaleDecorator(ITextualModel textualModel) : base(textualModel) {
            Console.WriteLine("Male Decorator");
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
