using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Text.Decorators
{
    internal class Subscript : TextDecorator, ISubscript
    {
        public Subscript(IText text) : base(text)
        {
            TextStyle = "subscript";
        }
    }
}
