using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_oop
{
    public abstract class Flyers : Animal
    {
        public bool IsBird { get; set; }
        public int WingsQuantity { get; set; }
        public bool CanFly { get; set; }
        public Flyers(string _Name, int _Age, bool _CanFly, int _WingsQuantity, bool _IsBird)
            : base(_Name, _Age)
        {
            CanFly = _CanFly;
            Name = _Name;
            WingsQuantity = _WingsQuantity;
            IsBird = _IsBird;
        }
        public Flyers()
        {

        }
    }
}
