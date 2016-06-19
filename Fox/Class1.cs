using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_oop
{
    public class Fox : WalkersCrawlers
    {
        public string WhatDoesTheFoxSay { get; set; }
        public Fox():base("",0,"",true)
        {
            WhatDoesTheFoxSay = "";
        }
        public Fox(string _Name, int _Age, string _WhatDoesTheFoxSay, string _Areal, bool _IsWalker = true)
            : base(_Name, _Age, _Areal, _IsWalker)
        {
            WhatDoesTheFoxSay = _WhatDoesTheFoxSay;
        }

    }
}
