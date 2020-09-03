using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool bButtton = false; 

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_DoubleClick_1(object sender, System.EventArgs e)
        {
            if (bButtton == false)
            {
                FactButton.Text = "냐옹";
                bButtton = true;
            }
            else
            {
                FactButton.Text = "멍멍";
                bButtton = false;
            }
        }

        private void FactButton_MouseMove(object sender, MouseEventArgs e)
        {
            FactButton.Text = "마우스 올라옴";
        }

        private void FactButton_MouseLeave(object sender, System.EventArgs e)
        {
            FactButton.Text = "마우스 떠남";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    textBox2.Text = textBox1.Text;
            //}
        }

        private void FactButton_Click(object sender, System.EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }
    }
}