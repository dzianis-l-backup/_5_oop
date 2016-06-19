using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_oop
{
    public class WalkersCrawlers : Animal
    {
        public bool IsWalker { get; set; }
        public string Areal { get; set; }
        public WalkersCrawlers(string _Name, int _Age, string _Areal, bool _IsWalker)
            : base(_Name, _Age)
        {
            Areal = _Areal;
            IsWalker = _IsWalker;
        }
        public WalkersCrawlers()
        {

        }
    }
}
