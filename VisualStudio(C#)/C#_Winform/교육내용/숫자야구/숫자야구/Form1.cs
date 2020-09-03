using System;
using System.Windows.Forms;

namespace 숫자야구
{
    public partial class Form1 : Form
    {
        int[] intArray;
        int Score;

        public Form1()
        {
            InitializeComponent();
           
        }

        private void Init()
        {
            Random r = new Random();
            intArray = new int[3] { 100, 100, 100 };

            // count : 랜덤숫자를 저장할 곳
            for (int count = 0; count < intArray.Length; count++)
            {
                int iTemp = r.Next(0, 10);

                // count2 : 생성된 랜덤숫자가 겹치는지 비교하는 곳
                int count2;
                for (count2 = 0; count2 < intArray.Length; count2++)
                {
                    if (iTemp == intArray[count2])
                    {
                        break;
                    }
                }
                if (count2 < intArray.Length) // 겹침
                {
                    count--;
                    continue;
                }
                intArray[count] = iTemp;
            }
            rd1.Text = intArray[0].ToString();
            rd2.Text = intArray[1].ToString();
            rd3.Text = intArray[2].ToString();

            Score = 0;
            lbCount.Text = Score.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] inputArray = new int[intArray.Length];
            int strikeCount = 0;
            int ballCount = 0;

            inputArray[0] = Convert.ToInt32(tbInput1.Text);
            inputArray[1] = Convert.ToInt32(tbInput2.Text);
            inputArray[2] = Convert.ToInt32(tbInput3.Text);

            for (int Count1 = 0; Count1 < intArray.Length; Count1++)
            {
                for (int Count2 = 0; Count2 < intArray.Length; Count2++)
                {
                    if (inputArray[Count1] == intArray[Count2]) // 숫자비교
                    {
                        if (Count1 == Count2) // 위치비교
                        {
                            MessageBox.Show("스트라이크");
                            strikeCount++;
                        }
                        else
                        {
                            MessageBox.Show("볼");
                            ballCount++;
                        }
                        break;
                    }
                }
            }
            if (strikeCount == 0 && ballCount == 0)
            {
                MessageBox.Show("아웃");
            }
            lbStrike.Text = strikeCount.ToString();
            lbBall.Text = ballCount.ToString();
            ++Score;
            lbCount.Text = Score.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Init();
            lbStrike.Text = "0";
            lbBall.Text = "0";
            tbInput1.Clear();
            tbInput2.Clear();
            tbInput3.Clear();
        }
    }
}
