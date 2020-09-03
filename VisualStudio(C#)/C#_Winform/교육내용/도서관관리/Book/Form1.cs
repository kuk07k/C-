using System.Windows.Forms;

namespace Book
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            bookBindingSource.Add(new Book() { Isbn = "9787763247564" , Name = "IT CookBook에 강한 실전 PLC", Publisher = "한빛아카데미", Page = 384, UserID = 0});
        }
    }
}
