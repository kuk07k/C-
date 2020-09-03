using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 식당_리스트
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            label2.Text = "회식장소는 : " + cb.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                comboBox1.Items.Add(comboBox1.Text);
                label2.Text = comboBox1.Text + "이 리스트에 추가되었습니다!";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                label2.Text = comboBox1.SelectedItem.ToString() + "이 리스트에서 삭제되었습니다!";
                comboBox1.Items.Remove(comboBox1.SelectedItem);
            }
        }
    }
}
