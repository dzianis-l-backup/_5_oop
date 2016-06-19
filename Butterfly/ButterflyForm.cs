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
    public partial class ButterflyForm : Form1
    {
        public static Butterfly _butter;
        
        public ButterflyForm()
        {
          
            InitializeComponent();
            _butter = new Butterfly();
            name.Text = _butter.Name;
            age.Text = _butter.Age.ToString();
            fly.Checked = _butter.CanFly;
            wings.Text = _butter.WingsQuantity.ToString();
            this.ControlBox = false;
           
        }

        

        private void ButterflyForm_Load(object sender, EventArgs e)
        {
           
        }
        public static void ValidateButter(ref Butterfly butter, string name, string age, bool CanFly, string wings)
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
            reg = new Regex(@"[\d]{1,1}");
            Match wi = reg.Match(wings.Trim());
            if (wi.Value == "")
            {
                ValidateError("wings");
                return;
            }
            butter.Name = na.Value;
            butter.Age = int.Parse(ag.Value);
            butter.CanFly = CanFly;
            butter.WingsQuantity = int.Parse(wi.Value);
            butter.IsBird = true;
           

        }
        public static void EmptyFields(TextBox t1, TextBox t2, CheckBox c1, TextBox t3)
        {
            t1.Text = "";
            t2.Text = "";
            t3.Text = "";
            c1.Checked = false;
        }
        public static void ValidateError(string str)
        {
            MessageBox.Show("Error in " + str + " parameter");
        }
        public static void ConfigButter(Butterfly butter, string name, string age, bool CanFly, string wings)
        {
            ValidateButter(ref  butter, name, age, CanFly, wings);
        }
        public override void BindContent(Animal butter)
        {
            ButterflyForm._butter = (Butterfly)butter;
            name.Text = _butter.Name;
            age.Text = _butter.Age.ToString();
            fly.Checked = _butter.CanFly;
            wings.Text = _butter.WingsQuantity.ToString();
        }

        private void submit_Click_1(object sender, EventArgs e)
        {
            ConfigButter(_butter, name.Text, age.Text, fly.Checked, wings.Text);
            this.Hide();
            EmptyFields(name, age, fly, wings);
        }
             
      
    }
}
