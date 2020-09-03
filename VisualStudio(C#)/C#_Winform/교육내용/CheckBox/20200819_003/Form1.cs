using System;
using System.Windows.Forms;

namespace _20200819_003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string checkStatus = "";

            CheckBox[] cBox = { checkBox1, 
                                checkBox2, 
                                checkBox3, 
                                checkBox4, 
                                checkBox5 };

            foreach (CheckBox Temp in cBox)
            {
                checkStatus = checkStatus + string.Format("{0} : {1}\n", Temp.Text, Temp.Checked);
                //checkStatus = checkStatus + Temp.Text + " : " + Temp.Checked + "\n";
            }

            //for (int i = 0; i < cBox.Length; i++)
            //{
            //    checkStatus = checkStatus + cBox[i].Text + " : " + cBox[i].Checked + "\n";
            //}

            //checkStatus = checkStatus + cBox[1].Text + " : " + checkBox2.Checked + "\n";
            //checkStatus = checkStatus + cBox[2].Text + " : " + checkBox3.Checked + "\n";
            //checkStatus = checkStatus + cBox[3].Text + " : " + checkBox4.Checked + "\n";
            //checkStatus = checkStatus + cBox[4].Text + " : " + checkBox5.Checked + "\n";

            MessageBox.Show(checkStatus, "체크박스 상태");
        }
    }
}
