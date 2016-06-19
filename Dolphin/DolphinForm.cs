using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace _3_oop
{
    public partial class DolphinForm : Form1
    {
        public static Dolphin _dolphin;
        public DolphinForm()
        {
            
            InitializeComponent();
            _dolphin = new Dolphin();
            name.Text = _dolphin.Name;
            location.Text = _dolphin.Location;
            speed.Text = _dolphin.Speed.ToString();
            this.ControlBox = false;
        }

        private void DolphinForm_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            
            ConfigDolphin(_dolphin, name.Text, age.Text, location.Text, speed.Text);
            this.Hide();
            EmptyFields(name, age, location, speed);          
      
        }

        public static void ValidateDolphin(ref Dolphin dolphin, string name, string age, string location, string speed)
        {
            Regex reg = new Regex(@"[\w]{1,15}");
            Match na = reg.Match(name.Trim());
            if (na.Value == "")
            {
                ValidateError("name");
                return;
            }
            reg = new Regex(@"[\d]{1,2}");
            Match ag = reg.Match(age.Trim());
            if (ag.Value == "")
            {
                ValidateError("age");
                return;
            }
            reg = new Regex(@"[\w]{1,15}");
            Match loc = reg.Match(location.Trim());
            if (loc.Value == "")
            {
                ValidateError("location");
                return;
            }

            reg = new Regex(@"[\d]{1,2}");
            Match sp = reg.Match(speed.Trim());
            if (sp.Value == "")
            {
                ValidateError("speed");
                return;
            }
            dolphin.Name = na.Value;
            dolphin.Age = int.Parse(ag.Value);
            dolphin.Location = loc.Value;
            dolphin.Speed = int.Parse(sp.Value);
            dolphin.IsFish = false;


        }
        public static void ValidateError(string str)
        {
            MessageBox.Show("Error in " + str + " parameter");
        }



        public static void EmptyFields(TextBox t1, TextBox t2, TextBox t3, TextBox t4)
        {
            t1.Text = "";
            t2.Text = "";
            t3.Text = "";
            t4.Text = "";
        }

        public static void ConfigDolphin(Dolphin dolp, string name, string age, string location, string speed)
        {
            ValidateDolphin(ref  dolp, name, age, location, speed);
        }
        public override void BindContent(Animal dolphin)
        {
            DolphinForm._dolphin = (Dolphin)dolphin;
            name.Text = _dolphin.Name;
            age.Text = _dolphin.Age.ToString();
            location.Text = _dolphin.Location;
            speed.Text = _dolphin.Speed.ToString();
        }


    }
    
}
