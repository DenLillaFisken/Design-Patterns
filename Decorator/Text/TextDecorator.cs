using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Text
{
    public abstract class TextDecorator : IText
    {
        public IText Text { get; set; }
        //public RegularText Text { get; set; }
        public string TextStyle;
        
        //public TextDecorator(RegularText text)
        public TextDecorator(IText text)
        {
            Text = text;
        }
        public string GetTextStyle()
        {
            return "<" + TextStyle + ">" + Text.GetTextStyle() + "</" + TextStyle + ">";
        }
    }
}
