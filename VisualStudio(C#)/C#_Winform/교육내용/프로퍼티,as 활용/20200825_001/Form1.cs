using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _20200825_001
{
    // Winform 에서 Console 예제처럼 사용가능
    public partial class Form1 : Form
    {
        class product : IComparable
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public override string ToString()
            {
                return Name + " : " + Price + "원";
            }

            public int CompareTo(object obj)
            {
                return Name.CompareTo((obj as product).Name); // as : 캐스팅 역할(가능하면 바꿔라)
                //return Price.CompareTo((obj as product).Price);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<product> alist = new List<product>() {
                new product(){Name = "고메", Price = 10000 },
                new product(){Name = "군고메", Price = 50000 },
                new product(){Name = "찐고메", Price = 30000 },
                new product(){Name = "짠고메", Price = 40000 },
                new product(){Name = "맛탕", Price = 20000 },
            };

            alist.Sort();
            string result = "";
            foreach (var item in alist)
            {
                result += (item + "\n");
            }

            MessageBox.Show(result);
        }
    }
}
