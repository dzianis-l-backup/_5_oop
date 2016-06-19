using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_oop
{
    public class Snake : _3_oop.WalkersCrawlers
    {
        public string WhatDoesTheSnakeSay { get; set; }
        public Snake(string _Name, int _Age, string _WhatDoesTheSnakeSay, string _Areal, bool _IsWalker = false)
            : base(_Name, _Age, _Areal, _IsWalker)
        {
            WhatDoesTheSnakeSay = _WhatDoesTheSnakeSay;
        }
        public Snake()
        {
        }

    }
}
