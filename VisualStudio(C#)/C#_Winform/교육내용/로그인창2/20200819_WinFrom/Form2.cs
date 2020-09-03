using System;
using System.Windows.Forms;

namespace _20200819_WinFrom
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        { 
            CenterToParent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("누르지 말랬지 !!!", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("이름을 입력해주세용", "경고", MessageBoxButtons.OK);
            }
            else
            {
                label2.Text = textBox1.Text + "님, 안녕하세용 !";
            }
        }
    }
}
