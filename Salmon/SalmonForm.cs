using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace _3_oop
{
    public partial class SalmonForm : Form
    {
        public SalmonForm()
        {
            InitializeComponent();
        }


    }
    public static class Methods
    {
        public static Salmon ValidateSalmon(string name, string age, bool CanFly, string wings)
        {
            Regex reg = new Regex(@"[\w]{1,15}");
            Match na = reg.Match(name.Trim());
            if (na.Value == "")
            {
                ValidateError("name");
                return null;
            }
            reg = new Regex(@"[\d]{1,2}");
            Match ag = reg.Match(age.Trim());
            if (ag.Value == "")
            {
                ValidateError("age");
                return null;
            }
            reg = new Regex(@"[\d]{1,1}");
            Match wi = reg.Match(wings.Trim());
            if (wi.Value == "")
            {
                ValidateError("wings");
                return null;
            }
            return new Salmon(na.Value, int.Parse(ag.Value), CanFly, int.Parse(wi.Value), true);

        }
        public static void ValidateError(string str)
        {
            MessageBox.Show("Error in " + str + " parameter");
        }
    }
}
