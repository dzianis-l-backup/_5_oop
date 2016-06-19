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
    public partial class FoxForm : Form1
    {
        public static Fox _fox;
        public FoxForm()
        {
         
            InitializeComponent();
            _fox = new Fox();
            name.Text = _fox.Name;
            age.Text = _fox.Age.ToString();
            foxsay.Text = _fox.WhatDoesTheFoxSay;
            areal.Text = _fox.Areal.ToString();
            this.ControlBox = false;
        }
        private void submit_Click(object sender, EventArgs e)
        {

          
        }

        public static void ValidateFox(ref Fox fox, string name, string age, string foxsay, string areal)
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
            Match fo = reg.Match(foxsay.Trim());
            if (fo.Value == "")
            {
                ValidateError("whatdoesthefoxsay");
                return;
            }

            reg = new Regex(@"[\w]{1,15}");
            Match ar = reg.Match(areal.Trim());
            if (ar.Value == "")
            {
                ValidateError("areal");
                return;
            }
            fox.Name = na.Value;
            fox.Age = int.Parse(ag.Value);
            fox.WhatDoesTheFoxSay = fo.Value;
            fox.Areal = ar.Value;
            fox.IsWalker = false;


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

        public static void ConfigFox(Fox fox, string name, string age, string foxsay, string areal)
        {
            ValidateFox(ref  fox, name, age, foxsay, areal);
        }
        public override void BindContent(Animal fox)
        {
            FoxForm._fox = (Fox)fox;
            name.Text = _fox.Name;
            age.Text = _fox.Age.ToString();
            foxsay.Text = _fox.WhatDoesTheFoxSay;
            areal.Text = _fox.Areal.ToString();
        }

        private void submit_Click_1(object sender, EventArgs e)
        {
            ConfigFox(_fox, name.Text, age.Text, foxsay.Text, areal.Text);
            this.Hide();
            EmptyFields(name, age, foxsay, areal);

        }



    }
    
}
