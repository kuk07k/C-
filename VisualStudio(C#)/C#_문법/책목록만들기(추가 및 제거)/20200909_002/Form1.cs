using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200909_002
{
    public partial class Form1 : Form
    {
        //int[] iPrice;
        //string[] sName;
        List<int> BookPrice = new List<int>();
        List<string> BookName = new List<string>();

        public Form1()
        {
            InitializeComponent();

            Book[] abook = new Book[] {
                                        new Book("책1", 5000),
                                        new Book("책2", 1000),
                                        new Book("책3", 4000),
                                        new Book("책4", 2000),
                                        new Book("책5", 10000),
                                        new Book("책6", 25000),
                                        new Book("책7", 15000)
                                      };
            foreach (var item in abook)
            {
                BookPrice.Add(item.Price);
                BookName.Add(item.Name);
            }

            //iPrice = new int[] { 90, 19, 34, 67, 56, 54 };
            //sName = new string[] { "용혁", "지윤", "효용", "동욱", "동우", "영환" };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //chart1.Series[0].Points.DataBindY(iPrice);
            //chart1.Series[0].Points.DataBindY(sName);
            chart1.Series[0].Points.DataBindXY(BookName, BookPrice);
            chart1.Series[0].IsValueShownAsLabel = true;  // 차트 하나하나의 값(책가격)표시
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                BookName.Add(textBox1.Text);
                BookPrice.Add(int.Parse(textBox2.Text));
                chart1.Series[0].Points.DataBindXY(BookName, BookPrice);
            }
            else
            {
                MessageBox.Show("책 제목과 가격을 입력해주세요");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                for (int i = 0; i < BookName.Count; i++)
                {
                    if (BookName[i] == textBox1.Text && BookPrice[i] == int.Parse(textBox2.Text))
                    {
                        BookPrice.RemoveAt(i);
                        BookName.RemoveAt(i);
                        break;
                    }
                }
                chart1.Series[0].Points.DataBindXY(BookName, BookPrice);
            }
            else
            {
                MessageBox.Show("책 제목과 가격을 입력해주세요");
            }
        }
    }
}
