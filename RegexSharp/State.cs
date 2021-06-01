using System;
using System.Collections.Generic;
using System.Text;

namespace RegexSharp
{
    class State
    {
        public string Name { get; set; }
        public string Left { get; set; }
        public string Right { get; set; }

        public string Operator { get; set; }
    }
}
