using System;
using System.Windows.Forms;

namespace DataTimePicker_날짜계산기
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, System.EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime selectedDay = dateTimePicker1.Value;

            textBox1.Text = today.Subtract(selectedDay).TotalDays.ToString("0");
        }
    }
}
