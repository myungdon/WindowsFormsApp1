using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, System.EventArgs e)
        {
            label1.Text = "Hello World!";
        }
    }
}
