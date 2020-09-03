using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControl
{
    public partial class Form1 : Form
    {
        private Timer myTimer = new Timer();
        private DateTime dDay;
        private DateTime tTime;
        private bool setAlarm;

        public Form1()
        {
            InitializeComponent();

            label3.ForeColor = Color.Gray;
            label4.ForeColor = Color.Gray;

            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "tt hh:mm";

            myTimer.Interval = 1000;
            myTimer.Tick += timer1_Tick;
            myTimer.Start();

            tabControl1.SelectedTab = tabPage2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dDay = DateTime.Parse(datePicker.Text);
            tTime = DateTime.Parse(timePicker.Text);

            setAlarm = true;
            label3.ForeColor = Color.Red;
            label4.ForeColor = Color.Blue;
            label4.Text = "Alarm : " + dDay.ToShortDateString() + "  " + tTime.ToLongTimeString();
            tabControl1.SelectedTab = tabPage2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setAlarm = false;
            label3.ForeColor = Color.Gray;
            label4.ForeColor = Color.Gray;
            label4.Text = "Alarm : ";
            tabControl1.SelectedTab = tabPage2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime cTime = DateTime.Now;
            label5.Text = cTime.ToShortDateString();
            label6.Text = cTime.ToLongTimeString();

            if (setAlarm == true)
            {
                if (dDay == DateTime.Today && cTime.Hour == tTime.Hour && cTime.Minute == tTime.Minute)
                {
                    setAlarm = false;
                    MessageBox.Show("Alarm!!");
                }
            }
        }
    }
}
