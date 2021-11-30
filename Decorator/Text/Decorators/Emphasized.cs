using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Text.Decorators
{
    internal class Emphasized : TextDecorator, IEmphasized
    {
        public Emphasized(IText text) : base(text)
        {
            TextStyle = "emphasized";
        }
    }
}
