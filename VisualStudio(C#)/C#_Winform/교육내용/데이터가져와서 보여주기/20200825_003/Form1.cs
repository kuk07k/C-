using System;
using System.IO;
using System.Windows.Forms;

namespace _20200825_003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            StreamReader R = new StreamReader(@"c:\factory.txt");
            while (true)
            {
                string rName = R.ReadLine();
                if (rName == null)
                {
                    break;
                }
                string rPrice = R.ReadLine();

                productBindingSource.Add(
                    new product() { Name = rName, Price = Convert.ToInt32(rPrice) });
            }

            //productBindingSource.Add(new product() {Name = "붕어빵", Price = 2000 });
            //productBindingSource.Add(new product() {Name = "햄버거", Price = 5400 });
            //productBindingSource.Add(new product() {Name = "피자", Price = 16000 });
            //productBindingSource.Add(new product() {Name = "치킨", Price = 22000 });
            //productBindingSource.Add(new product() {Name = "사탕", Price = 500 });
            //productBindingSource.Add(new product() {Name = "안경", Price = 15000 });
        }
    }
}
