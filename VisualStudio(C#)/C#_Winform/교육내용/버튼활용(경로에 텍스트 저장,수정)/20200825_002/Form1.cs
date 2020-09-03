using System;
using System.IO;
using System.Windows.Forms;

namespace _20200825_002
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                throw new Exception();
            }
            catch (Exception error)
            {

                MessageBox.Show("예외 발생");
            }
        }

            private void button1_Click1(object sender, EventArgs e)
        {
            StreamReader R = new StreamReader(@"c:\factory.txt");

            string readResult;
            while (true)
            {
                readResult = R.ReadLine();
                if (readResult == null)
                {
                    break;
                }
                MessageBox.Show(readResult);
            }
        }

            // 간단하게 텍스트파일 만들기, 읽어오기
            private void button1_Click2(object sender, EventArgs e)
        {
            //File.WriteAllText("c:\\factory.txt","factory"); // 저장할 경로, 저장할 내용

            //File.WriteAllText(@"c:\factory.txt","factory");

            //string Temp = File.ReadAllText(@"c:\factory.txt");
            //MessageBox.Show(Temp);

            //StreamWriter W = new StreamWriter(@"c:\factory.txt");
            //W.WriteLine("지옥으로 키티");
            //W.WriteLine("천국으로 스머프");
            //W.Close();


            int[] aint = new int[] { 3, 6, 78, 20, 44 };
            StreamWriter W = new StreamWriter(@"c:\factory.txt");
            W.WriteLine("지옥으로 키티");
            W.WriteLine("천국으로 스머프");
            foreach (var item in aint)
            {
                W.Write(item + " , ");
            }
            W.WriteLine();
            W.WriteLine("쉬어야해");
            W.Close();
        }
    }
}
