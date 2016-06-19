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
using System.Reflection;

namespace _3_oop
{
    public partial class BirdForm : Form1
    {
        public static Bird _bird;
      
        public BirdForm()
        {
            _bird = new Bird();
            InitializeComponent();
            name.Text = _bird.Name;
            age.Text = _bird.Age.ToString();
            fly.Checked = _bird.CanFly;
            wings.Text = _bird.WingsQuantity.ToString();          
            this.ControlBox = false;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            ConfigBird(_bird,name.Text,age.Text,fly.Checked,wings.Text);
            this.Hide();
            EmptyFields(name, age, fly, wings);
        }

        private void BirdForm_Load(object sender, EventArgs e)
        {
           
        }
        
        public static void ValidateBird(ref Bird bird, string name, string age, bool CanFly, string wings)
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
            bird.Name = na.Value;
            bird.Age = int.Parse(ag.Value);
            bird.CanFly = CanFly;
            bird.WingsQuantity = int.Parse(wi.Value);
            bird.IsBird = true;
           

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
        public static void ConfigBird(Bird bird, string name, string age, bool CanFly, string wings)
        {
            ValidateBird(ref bird, name, age, CanFly, wings);
        }
        public override void BindContent(Animal bird)
        {            
            BirdForm._bird = (Bird)bird;
            name.Text = _bird.Name;
            age.Text = _bird.Age.ToString();
            fly.Checked = _bird.CanFly;
            wings.Text = _bird.WingsQuantity.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
             
      
    }
}
