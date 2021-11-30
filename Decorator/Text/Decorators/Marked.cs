using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Text.Decorators
{
    internal class Marked : TextDecorator, IMarked
    {
        public Marked(IText text) : base(text)
        {
            TextStyle = "marked";
        }
    }
}
