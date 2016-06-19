using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;
using XMLInt;


namespace XML
{
    public partial class XMLForm : XMLInterface
    {
        public XMLForm()
        {
            InitializeComponent();
            Enc = new List<Encoding>();
            xmlXslt = new List<string>();
            Enc.Add(Encoding.UTF8);
            Enc.Add(Encoding.ASCII);
            this.ControlBox = false;
            xmlXslt.Add("xml");
            xmlXslt.Add("xslt");
            encoding.Items.Add("UTF-8");
            encoding.Items.Add("ASCII");
            type.Items.Add("xml");
            type.Items.Add("xslt");
            _obj = null;
            _ListObj = null;
            
        }
        public List<Encoding> Enc;
        public List<string> xmlXslt;
        public static Object _obj;
        public static List<Object> _ListObj;
         

        public  void SerializeFormatSave(Object obj)
        {
            try
            {
                string serialized = Serialize(obj);
                serialized = @"{JsonArray:" + serialized + "}";
                XmlDocument doc = JsonConvert.DeserializeXmlNode(serialized);

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "xml|.xml";
                saveFileDialog1.Title = "Save an xml File";
                saveFileDialog1.ShowDialog();


                if (saveFileDialog1.FileName != "")
                {
                    // Byte[] bytes = Encoding.UTF8.GetBytes(doc.ToString()
                    System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                    // fs.Write(), 0, bytesInStream.Length);
                    //
                    doc.Save(fs);
                    fs.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }
        public  void SerializeFormatSave(List<Object> ListObj)
        {
            try
            {
                string serialized = Serialize(ListObj);
                //serialized
                serialized = @"{root:{JsonConv:" + serialized + "}}";
                XmlDocument doc = JsonConvert.DeserializeXmlNode(serialized);

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "xml|.xml";
                saveFileDialog1.Title = "Save an xml File";
                saveFileDialog1.ShowDialog();


                if (saveFileDialog1.FileName != "")
                {
                    // Byte[] bytes = Encoding.UTF8.GetBytes(doc.ToString()
                    System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                    // fs.Write(), 0, bytesInStream.Length);
                    //
                    //
                   
                    doc.Save(fs);
                    fs.Close();
                    if (type.SelectedIndex > -1 && type.Items[type.SelectedIndex] == "xslt")
                    {
                        XslTransform myXslTransform = new XslTransform();
                        FileStream f = File.Create(saveFileDialog1.FileName + ".html");
                        f.Close();
                        myXslTransform.Load("output.xsl");
                        myXslTransform.Transform( saveFileDialog1.FileName,saveFileDialog1.FileName+".html");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }

        }
        public string SerializeJson(Object obj)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            string json = JsonConvert.SerializeObject(obj, settings);
            return json;
        }
        public string Serialize(Object obj)
        {
            string seralized = "";

            seralized += "";

            seralized += SerializeJson(obj) + "";
            return seralized;
            //serialized
        }
        public string Serialize(List<Object> ListObj)
        {
            string seralized = "";

            seralized += "[";

            for (int i = 0; i < ListObj.Count; ++i)
            {
                seralized += SerializeJson(ListObj[i]) + ",";
            }
            seralized = seralized.Substring(0, seralized.Length - 1);//without the last ,;
            seralized += "]";
            return seralized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_obj != null)
                SerializeFormatSave(_obj);
            if (_ListObj != null)
                SerializeFormatSave(_ListObj);
            _obj = null;
            _ListObj = null;
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            _obj = null;
            _ListObj = null ;
        }

        public override void Bind(List<object> obj)
        {
            //Type t = obj.GetType();
            //Type l = typeof(List<Object>);
            //if ( t.Name==l.Name )
            //{
            //    _ListObj = (List<Object>)obj;
            //    return;
            //}

            _ListObj = obj;
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
    }
}
