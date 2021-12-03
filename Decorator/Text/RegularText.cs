using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Text
{
    public class RegularText: IRegularText
    {
        public string TextStyle { get; private set; }
        public string Input { get; set; }

        public RegularText(string input)
        {
            TextStyle = "";
            Input = input;
        }
        public string GetTextStyle()
        {
            return Input;
        }
    }
}
