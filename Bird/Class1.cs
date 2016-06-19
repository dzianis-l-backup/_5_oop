using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.Serialization;

namespace _3_oop
{
   
    public class Bird : Flyers
    {
       
        public Bird(string _Name, int _Age, bool _CanFly, int _WingsQuantity, bool _IsBird = true)
            : base(_Name, _Age, _CanFly, _WingsQuantity, _IsBird)
        {
        }
        
        
        public Bird():
            base("",0,false,0,true)
        {
        
                
        }

        

    }
    
}
