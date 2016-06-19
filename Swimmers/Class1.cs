using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_oop
{
    public class Swimmers : Animal
    {
        public bool IsFish { get; set; }
        public int Speed { get; set; }
        public string Location { get; set; }
        public Swimmers(string _Name, int _Age, string _Location, int _Speed, bool _IsFish)
            : base(_Name, _Age)
        {
            Location = _Location;
            Name = _Name;
            IsFish = _IsFish;
            Speed = _Speed;
        }
        public Swimmers()
        {
        }
    }
}
