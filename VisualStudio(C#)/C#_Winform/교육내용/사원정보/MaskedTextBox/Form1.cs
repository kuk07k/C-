using System;
using System.Windows.Forms;

namespace MaskedTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";

            str = str + label1.Text + " : " + maskedTextBox1.Text + "\n";
            str = str + label2.Text + " : " + maskedTextBox2.Text + "\n";
            str = str + label3.Text + " : " + textBox1.Text + "\n";
            str = str + label4.Text + " : " + maskedTextBox4.Text + "\n";
            str = str + label5.Text + " : " + maskedTextBox5.Text + "\n";
            str = str + label6.Text + " : " + textBox2.Text + "\n";

            MessageBox.Show(str, "개인 정보");
        }
    }
}
