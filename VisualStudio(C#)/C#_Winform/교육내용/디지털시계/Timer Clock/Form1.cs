using System;
using System.Windows.Forms;

namespace Timer_Clock
{
    public partial class Form1 : Form
    {
        //var는 메소드안에서 사용가능
        private int CountMS = 0;
        private int CountM = 0;
        private int CountS = 0;
        private bool Toggle = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e) // 숫자만 바꾸는 Tick
        {
            ++CountMS;
            if (CountMS == 60)
            {
                CountMS = 0;
                ++CountS;
                if (CountS == 60)
                {
                    CountS = 0;
                    ++CountM;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)// 비주얼 Tick
        {
            DisM.Text = CountM.ToString();
            DisS.Text = CountS.ToString();
            DisMS.Text = CountMS.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Toggle == false)
            {
                timer1.Start();
                timer2.Start();
                Toggle = true;
            }
            else
            {
                timer1.Stop();
                timer2.Stop();
                Toggle = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            Toggle = false;
            CountM = 0;
            CountMS = 0;
            CountS = 0;
            DisM.Text = CountM.ToString();
            DisS.Text = CountS.ToString();
            DisMS.Text = CountMS.ToString();
        }
    }
}
