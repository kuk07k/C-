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
                                        new Book("한번도 경험해보지 못한 나라", 5000),
                                        new Book("돈의 속성", 1000),
                                        new Book("아몬드", 4000),
                                        new Book("심판", 2000),
                                        new Book("살고 싶다는 농담", 10000),
                                        new Book("부의 대이동", 25000),
                                        new Book("김미경의 리부트", 15000)
                                      };
            foreach (var item in abook)
            {
                BookPrice.Add(item.Price);
                BookName.Add(item.Name);
            }

         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateChart();
            
        }

        private void UpdateChart()
        {
            chart1.Series[0].Points.DataBindXY(BookName, BookPrice);
            chart1.Series[0].IsValueShownAsLabel = true;  // 차트 하나하나의 값(책가격)표시        
        }

            private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if(BookName.Contains(textBox1.Text))
                {
                    MessageBox.Show("이미 있는 책이름입니다.");
                }
                else
                {
                    BookName.Add(textBox1.Text);
                    BookPrice.Add(int.Parse(textBox2.Text));
                    chart1.Series[0].Points.DataBindXY(BookName, BookPrice);
                }
            }
            else
            {
                MessageBox.Show("책 제목과 가격을 입력해주세요");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" )
            {
                if(BookName.Contains(textBox1.Text))
                {
                    BookPrice.RemoveAt(BookName.IndexOf(textBox1.Text));
                    BookName.Remove(textBox1.Text);
                    chart1.Series[0].Points.Clear();
                    UpdateChart();
                }
                else
                {
                    MessageBox.Show("삭제하려는 책이름이 없습니다.");
                }
            }
            else
            {
                MessageBox.Show("책 제목을 입력해주세요");
            }
        }
    }
}
