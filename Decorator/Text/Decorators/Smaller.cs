using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Text.Decorators
{
    internal class Smaller : TextDecorator, ISmaller
    {
        public Smaller(IText text) : base(text)
        {
            TextStyle = "smaller";
        }
    }
}
