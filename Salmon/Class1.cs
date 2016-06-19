using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_oop
{
    public class Salmon : Swimmers
    {
        public Salmon(string _Name, int _Age, string _Location, int _Speed, bool _IsFish = true)
            : base(_Name, _Age, _Location, _Speed, _IsFish)
        {

        }
        public Salmon()
        {

        }
    }
}
