using Design_Patterns_Assignment.Decorator.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
    public class FCT
    {
        public static IText createText(string input)
        {
            return new RegularText(input);
        }
    }
}
