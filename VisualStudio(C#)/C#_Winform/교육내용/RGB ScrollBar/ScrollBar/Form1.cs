using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScrollBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.LightSteelBlue;
            panel1.BackColor = Color.FromArgb(0, 0, 0);
            textBox1.Text = 0.ToString();
            textBox2.Text = 0.ToString();
            textBox3.Text = 0.ToString();
            hScrollBar1.Maximum = 255 + 9;
            hScrollBar2.Maximum = 255 + 9;
            hScrollBar3.Maximum = 255 + 9;
        }

        private void Scr_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = hScrollBar1.Value.ToString();
            textBox2.Text = hScrollBar2.Value.ToString();
            textBox3.Text = hScrollBar3.Value.ToString();
            panel1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                hScrollBar1.Value = int.Parse(textBox1.Text);
                hScrollBar2.Value = int.Parse(textBox2.Text);
                hScrollBar3.Value = int.Parse(textBox3.Text);
                panel1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            }
        }
    }
}
