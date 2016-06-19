using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_oop
{
    public class Dolphin : Swimmers
    {
        public Dolphin(string _Name, int _Age, string _Location, int _Speed, bool _IsFish = false)
            : base(_Name, _Age, _Location, _Speed, _IsFish)
        {

        }
        public Dolphin():base("",0,"",0,false)
        {

        }
    }
}
