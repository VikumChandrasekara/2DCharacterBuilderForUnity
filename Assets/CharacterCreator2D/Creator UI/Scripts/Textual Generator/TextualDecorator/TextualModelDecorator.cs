using System;

namespace Assets.CharacterCreator2D.Creator_UI.Scripts.Textual_Generator.TextualDecorator
{
    public abstract class TextualModelDecorator : ITextualModel
    {
        public ITextualModel TextualModel;

        public TextualModelDecorator(ITextualModel textualModel)
        {
            this.TextualModel = textualModel;
        }

        public  bool Design()
        {
            TextualModel.Design();
            return false;
        }
    }
}
