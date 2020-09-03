using System;
using System.Windows.Forms;

namespace A135_RadioBox
{
    public partial class Form1 : Form
  {
        //private RadioButton checkedRB;
        private string gender = "미입력";

        public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string result = "국적 : ";
            for (var i = 0; i < groupBox1.Controls.Count; i++)
            {
                RadioButton Temp = (RadioButton)groupBox1.Controls[i];
                if (Temp.Checked)
                {
                    result = result + Temp.Text;
                    break;
                }
            }
            result = result + "\n성별 : " + gender;
            MessageBox.Show(result, "Result");

            //if (rbKorea.Checked)
            //  result += "국적 : 대한민국\n";
            //else if (rbChina.Checked)
            //  result += "국적 : 중국\n";
            //else if (rbJapan.Checked)
            //  result += "국적 : 일본\n";
            //else if (rbOthers.Checked)
            //  result += "국적 : 그 외의 국가\n";

            //if (checkedRB == rbMale)
            //  result += "성별 : 남성";
            //else if (checkedRB == rbFemale)
            //  result += "성별 : 여성";

            //MessageBox.Show(result, "Result");
        }

    private void rbMale_CheckedChanged(object sender, EventArgs e)
    {
            //checkedRB = rbMale;
            gender = "남성";
    }

    private void rbFemale_CheckedChanged(object sender, EventArgs e)
    {
            //checkedRB = rbFemale;
            gender = "여성";
        }
  }
}
