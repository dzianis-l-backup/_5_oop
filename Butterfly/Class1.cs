using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_oop
{
    public class Butterfly : Flyers
    {
        public Butterfly(string _Name, int _Age, bool _CanFly, int _WingsQuantity, bool _IsBird = false)
            : base(_Name, _Age, _CanFly, _WingsQuantity, _IsBird)
        {
        }
        public Butterfly():base("",0,false,0,false)
        {
        }
    }
}
