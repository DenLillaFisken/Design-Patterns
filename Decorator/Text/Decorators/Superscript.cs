using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Text.Decorators
{
    internal class Superscript : TextDecorator, ISuperscript
    {
        public Superscript(IText text) : base(text)
        {
            TextStyle = "sup";
        }
    }
}
