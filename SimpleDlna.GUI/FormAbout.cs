using System.Text;
using SimpleDlna.GUI.Properties;
using SimpleDlna.Utilities;
using NMaier.Windows.Forms;

namespace SimpleDlna.GUI
{
  internal sealed partial class FormAbout : Form
  {
    public FormAbout()
    {
      InitializeComponent();
      Text = $"About {ProductInformation.Title}";
      Product.Text = ProductInformation.Title;
      Product.Font = BoldFont;
      Version.Text = $"Version {ProductInformation.ProductVersion}";
      Copyright.Text = ProductInformation.Copyright;
      Copyright.Font = ItalicFont;
      License.Text = Encoding.UTF8.GetString(Resources.LICENSE);
    }
  }
}
