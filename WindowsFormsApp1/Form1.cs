using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void ButtonClick(object sender, System.EventArgs e)
        //{
        //    label1.Text = "Hello World!";
        //}

        // 로그인 창
        private void SingInButton_Click(object sender, System.EventArgs e)
        {
            string userId = id.Text;
            string userPassword = password.Text;

            if(userId.Equals("JMD") && userPassword.Equals("1")){
                MessageBox.Show("로그인에 성공했습니다.", "로그인");
            } else
            {
                MessageBox.Show("로그인에 실패했습니다.", "로그인");
            }
        }
    }
}
