using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpPcap;

namespace Security
{
    //winpcap
    //sharppcap
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(SharpPcap.Version.VersionString); 
            // Sharp : C# , pcap : Packet capture   //설치가 잘되었는지 확인

            CaptureDeviceList NicList = CaptureDeviceList.Instance;
            //MessageBox.Show(NicList.Count.ToString());

            string NicListResult = "";

            foreach (ICaptureDevice Temp in NicList)
            {
                string[] arrTemp = Temp.ToString().Split('\n');

                NicListResult += (arrTemp[1].Substring("FriendlyName".Length) + "\n"); 
            }

            //MessageBox.Show(NicListResult);








            Button[] abutton = new Button [3];
            abutton[0].Text = "button2";
            abutton[1].Text = "button3";
            abutton[2].Text = "button4";
            abutton[3].Text = "button5";
            foreach (var item in abutton)
            {
                Controls.Add(item);
            }


            //Button aButton = new Button();
            //aButton.Text = "button2";
            //aButton.Name = "button2";

            //Controls.Add(aButton);
        }
    } 
}
