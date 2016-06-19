using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace _3_oop
{
   // public interface IBind
   // {
        //
    //}
    public class Form1 : Form
    {
        public Form1()
            : base()
        { }
        public virtual void BindContent(Animal an) { }
    }
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Animal()
        {

        }
        public Animal(string _Name, int _Age)
        {
            Name = _Name;
            Age = _Age;
        }
       
    }
}
