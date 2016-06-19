using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Xml;

using XMLInt;


namespace _3_oop
{
    public partial class MainForm : Form
    {

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "dll files|*.dll";
            openFileDialog1.Title = "Select a dll";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string sFileName = openFileDialog1.FileName;
                var dll = Assembly.LoadFile(sFileName);

                foreach (Type type in dll.GetExportedTypes())
                {
                    var t = Activator.CreateInstance(type);
                    if (t is Form1)
                    {
                        bool Added = false;
                        for (int i = 0; i < ListOfForms.Count; ++i)
                            if (t.GetType() == ListOfForms[i].GetType())
                            {
                                Added = true;
                                break;
                            }
                        if (!Added)
                            ListOfForms.Add((Form1)Activator.CreateInstance(type));

                        // classSelection.Items.Add(type);
                    }
                    if (t is Animal)
                    {
                        bool Added = false;
                        for (int i = 0; i < ListOfTypes.Count; ++i)
                            if (t.GetType() == ListOfTypes[i])
                            {
                                Added = true;
                                break;
                            }
                        if (!Added)
                        {
                            classSelection.Items.Add(type.Name);
                            ListOfTypes.Add(type);
                            types.Add(type);
                        }

                    }

                }

            }


        }




        public List<Animal> ListOfAnimal { get; set; }
        public List<Form1> ListOfForms { get; set; }
        public List<Type> ListOfTypes { get; set; }
        public List<XMLInt.XMLInterface> ListOfFormating { get; set; }
        public List<Type> types;
        public MainForm()
        {
            InitializeComponent();
            ListOfAnimal = new List<Animal>();//created instances
            ListOfForms = new List<Form1>();//list of forms for instances
            ListOfTypes = new List<Type>();//list of types included
            types = new List<Type>();//list of all the types met in the program
            ListOfFormating = new List<XMLInt.XMLInterface>();
            types.Add(typeof(Animal));
            types.Add(typeof(Flyers));
            types.Add(typeof(WalkersCrawlers));
            types.Add(typeof(Swimmers));
            types.Add(typeof(List<Animal>));
        }


        private void _Delete_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void Serialize_Click(object sender, EventArgs e)
        {

            try
            {
                _Console.Text = "";
                _Console.Text += "[";
                for (int i = 0; i < ListOfAnimal.Count; ++i)
                {
                    _Console.Text += SerializeJson(ListOfAnimal[i]) + ",";
                }
                _Console.Text = _Console.Text.Substring(0, _Console.Text.Length - 1);//without the last ,;
                _Console.Text += "]";

                while (ChooseAnimal.Items.Count > 0)
                {
                    ChooseAnimal.Items.RemoveAt(0);
                }
                ListOfAnimal = new List<Animal>();

                /*while (ChooseAnimal.Items.Count > 0)
                {
                    ChooseAnimal.Items.RemoveAt(0);
                }
                ListOfAnimal = new List<Animal>();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deserialization error");
            }
        }



        private void Deserialize_Click(object sender, EventArgs e)
        {
            try
            {

                /*Regex r = new Regex("(?<=(\\\"\\$type\\\":\"))[_\\d\\w\\.]{1,}", RegexOptions.IgnoreCase);//:\"[_\\d\\w]{1,}/\\."
                MatchCollection m = r.Matches(_Console.Text);
                Type t = null;
                ListOfAnimal = new List<Animal>();
                List<Type> LocalTypes = new List<Type>();
                
                for (int j=0; j < m.Count; ++j)
                {
                    for (int i = 0; i < types.Count; ++i)
                    {
                        if (m[j].Value == types[i].FullName)
                        {
                            LocalTypes.Add(types[i]);
                            t = types[i];
                            break;
                        }
                    }
                }


              



                Form1 form;
                JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.None, Binder = new binder(LocalTypes.ToArray()) }; //,};
                List<Animal> animal = (List < Animal >) JsonConvert.DeserializeObject(ChangeProp.Text, LocalTypes.GetType());
                for (int i = 0; i < ListOfForms.Count; ++i)
                {
                    string FormName = ListOfForms[i].GetType().Name;
                    FormName = FormName.Substring(0, ListOfForms[i].GetType().Name.Length - 4);
                    if (FormName == animal.GetType().Name)
                    {
                        form = ListOfForms[i];
                        form.BindContent(animal);
                        form.Show();
                        break;
                    }
                }
                ChangeProp.Text = "";
                  */




                Regex r = new Regex("(?<=(\\\"\\$type\\\":\"))[_\\d\\w\\.]{1,}", RegexOptions.IgnoreCase);//:\"[_\\d\\w]{1,}/\\."
                MatchCollection m = r.Matches(_Console.Text);
                Type t = null;

                List<Type> LocalTypes = new List<Type>();

                for (int j = 0; j < m.Count; ++j)
                {
                    for (int i = 0; i < types.Count; ++i)
                    {
                        if (m[j].Value == types[i].FullName)
                        {
                            LocalTypes.Add(types[i]);
                            t = types[i];
                            break;
                        }
                    }
                }


                List<string> lstr = new List<string>();

                string desrialize = _Console.Text.Substring(1, _Console.Text.Length - 1);
                Regex CutTheLast = new Regex(@"\{.{1,}\},(?={""\$type"")");
                Match Node = CutTheLast.Match(desrialize);
                while (Node.Value != "")//single
                {
                    int index = desrialize.IndexOf(Node.Value);
                    string cleanPath = (index < 0)
                        ? desrialize
                        : desrialize.Remove(index, Node.Value.Length);

                    index = desrialize.IndexOf(cleanPath);
                    desrialize = (index < 0)
                        ? desrialize
                        : desrialize.Remove(index, cleanPath.Length);

                    lstr.Add(cleanPath.Substring(0, cleanPath.Length - 1));//without ,
                    Node = CutTheLast.Match(desrialize);
                }
                lstr.Add(desrialize.Substring(0, desrialize.Length - 1));//without []

                // = desrialize.Substring(0,desrialize.Length-1).Split(" ");



                _Console.Text = "";
                for (int k = LocalTypes.Count - 1; k > -1; --k)
                {
                    Animal animal = (Animal)JsonConvert.DeserializeObject(lstr[k], LocalTypes[LocalTypes.Count - 1 - k]);
                    ChooseAnimal.Items.Add(animal.GetType().Name + "_" + "Instance");
                    ListOfAnimal.Add(animal);
                }





            }
            catch (Exception ex)
            {
                MessageBox.Show("Deserialization error");
            }
        }

        private void _delete_Click(object sender, EventArgs e)
        {
            if (ChooseAnimal.SelectedIndex == -1)
                return;
            int ind = ChooseAnimal.SelectedIndex;
            ListOfAnimal.RemoveAt(ind);
            ChooseAnimal.Items.RemoveAt(ind);
        }

        private void change_Click(object sender, EventArgs e)
        {
            if (ChooseAnimal.SelectedIndex == -1)
                return;
            Form1 form;
            Animal animal = ListOfAnimal[ChooseAnimal.SelectedIndex];
            for (int i = 0; i < ListOfForms.Count; ++i)
            {
                string FormName = ListOfForms[i].GetType().Name;
                FormName = FormName.Substring(0, ListOfForms[i].GetType().Name.Length - 4);
                if (FormName == animal.GetType().Name)
                {
                    form = ListOfForms[i];
                    form.BindContent(animal);
                    form.ShowDialog();
                    break;
                }
            }
        }

        private void classSelection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void create_Click(object sender, EventArgs e)
        {
            if (classSelection.SelectedIndex == -1)
                return;
            Type type = ListOfTypes[classSelection.SelectedIndex];
            Animal animal = (Animal)Activator.CreateInstance(type);
            ChooseAnimal.Items.Add(animal.GetType().Name + "_" + "Instance");
            ListOfAnimal.Add(animal);
            //ListOfAnimal.Add(animal);
            Form1 form;
            for (int i = 0; i < ListOfForms.Count; ++i)
            {
                string FormName = ListOfForms[i].GetType().Name;
                FormName = FormName.Substring(0, ListOfForms[i].GetType().Name.Length - 4);
                if (FormName == type.Name)
                {
                    form = ListOfForms[i];
                    form.BindContent(animal);
                    form.ShowDialog();
                    break;
                }
            }
            //form.BindContent(animal);


        }

        private void ser_Click(object sender, EventArgs e)
        {
            if (ChooseAnimal.SelectedIndex == -1)
                return;
            int ind = ChooseAnimal.SelectedIndex;
            Animal an = ListOfAnimal[ind];
            ChangeProp.Text = SerializeJson(an);
        }

        private void des_Click(object sender, EventArgs e)
        {
            if (ChooseAnimal.SelectedIndex == -1)
                return;
            try
            {
                JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.None }; //
                Regex r = new Regex("(?<=(\\\"\\$type\\\":\"))[_\\d\\w]{1,}\\.[_\\d\\w]{1,}");//:\"[_\\d\\w]{1,}/\\."
                Match m = r.Match(ChangeProp.Text);
                Type t = null;
                for (int i = 0; i < types.Count; ++i)
                {
                    if (m.Value == types[i].FullName)
                    {

                        t = types[i];
                        break;
                    }
                }






                Form1 form;
                Animal animal = (Animal)JsonConvert.DeserializeObject(ChangeProp.Text, t);
                for (int i = 0; i < ListOfForms.Count; ++i)
                {
                    string FormName = ListOfForms[i].GetType().Name;
                    FormName = FormName.Substring(0, ListOfForms[i].GetType().Name.Length - 4);
                    if (FormName == animal.GetType().Name)
                    {
                        form = ListOfForms[i];
                        form.BindContent(animal);
                        form.ShowDialog();
                        break;
                    }
                }
                ChangeProp.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deserialization error");
            }

        }
        public string SerializeJson(Animal an)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            string json = JsonConvert.SerializeObject(an, settings);
            return json;
        }

        private void format_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "dll files|*.dll";
            openFileDialog1.Title = "Select a dll";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string sFileName = openFileDialog1.FileName;
                var dll = Assembly.LoadFile(sFileName);

                foreach (Type type in dll.GetExportedTypes())
                {
                    var t = Activator.CreateInstance(type);
                    if (t is XMLInt.XMLInterface)
                    {
                        bool Added = false;
                        for (int i = 0; i < ListOfFormating.Count; ++i)
                            if (t.GetType() == ListOfFormating[i].GetType())
                            {
                                Added = true;
                                break;
                            }
                        if (!Added)
                        {
                            ListOfFormating.Add((XMLInt.XMLInterface)Activator.CreateInstance(type));
                            formating.Items.Add(t.GetType().Name);
                        }


                    }

                }

            }

        }

        private void formating_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void objtoxml_Click(object sender, EventArgs e)
        {
            /*if (formating.SelectedIndex < 0)
                return;
            if (ChooseAnimal.SelectedIndex < 0)
                return;
            XMLInterface f = ListOfFormating[formating.SelectedIndex];
            f.Bind(ListOfAnimal[ChooseAnimal.SelectedIndex]);
            f.ShowDialog();*/
        }

        private void listoxml_Click(object sender, EventArgs e)
        {
            if (formating.SelectedIndex < 0)
                return;
            if (ListOfAnimal.Count == 0)
                return;
            XMLInterface f = ListOfFormating[formating.SelectedIndex];
            f.Bind(new List<Object>(ListOfAnimal));
            f.ShowDialog();
        }

        private void download_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "xml files|*.xml";
            openFileDialog1.Title = "Select an xml";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string sFileName = openFileDialog1.FileName;
                System.Xml.XmlDocument d = new XmlDocument();
                d.Load(sFileName);
                XmlNodeList elemList = d.GetElementsByTagName(@"JsonConv");
                for (int i = 0; i < elemList.Count; ++i)
                {
                    string js = JsonConvert.SerializeXmlNode(elemList[0]);
                    js = js.Substring(12, js.Length - 13);
                    MessageBox.Show(js);
                }
               
                
            }





        }


    }
}