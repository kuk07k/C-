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
using System.Net;
using System.Text.RegularExpressions;

namespace whiteShark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> NicName = new List<string>();
            foreach (ICaptureDevice Temp in CaptureDeviceList.Instance)
            {
                string[] arrTemp = Temp.ToString().Split('\n');
                NicName.Add(arrTemp[1].Substring("FriendlyName: ".Length));
            }

            for (int iTemp = 0; iTemp < NicName.Count; ++iTemp)
            {
                Button aButton = new Button();
                aButton.Text = NicName[iTemp];
                aButton.Name = "Facto" + iTemp;
                aButton.Location = new Point(30, 30 + iTemp * 30);
                aButton.Click += new EventHandler(Facto_Click);
                Controls.Add(aButton);
            }

            (sender as Button).Enabled = false;
        }


        private void Print_MAC(byte[] EtherData)
        {
            int XMargin = 10;
            int XSize = 120;
            int XInterval = 10;
            int YMargin = 15;
            int YSize = 20;
            int YInterval = 10;

            

            List<FactoLabel> aFactoLabel = new List<FactoLabel>();
            string data1 = string.Format("{0:X2}", EtherData[0]);
            for (int iTemp = 1; iTemp < 6; ++iTemp)
            {
                data1 += string.Format("-{0:X2}", EtherData[iTemp]);
            }
            aFactoLabel.Add(new FactoLabel() { Name = "Destination MAC", Value = data1.ToString() });
            string data2 = string.Format("{0:X2}", EtherData[6]);
            for (int iTemp = 7; iTemp < 12; ++iTemp)
            {
                data2 += string.Format("-{0:X2}", EtherData[iTemp]);
            }
            aFactoLabel.Add(new FactoLabel() { Name = "Source MAC", Value = data2.ToString() });
            int iNum = BitConverter.ToInt16(EtherData.Skip<byte>(12).Take(2).Reverse<byte>().ToArray(), 0);
            switch (iNum)
            {
                case 0x0200:
                    data2 = "Xerox PUP";
                    break;
                case 0x0500:
                    data2 = "Sprite";
                    break;
                case 0x0800:
                    data2 = "IP";
                    break;
                case 0x0806:
                    data2 = "Address resolution";
                    break;
                case 0x8035:
                    data2 = "Reverse ARP";
                    break;
                case 0x809B:
                    data2 = "AppleTalk protocol";
                    break;
                case 0x80F3:
                    data2 = "AppleTalk ARPP";
                    break;
                case 0x8100:
                    data2 = "IEEE 802.1Q VLAN taggingP";
                    break;
                case 0x8137:
                    data2 = "IPX";
                    break;
                case 0x86dd:
                    data2 = "IP protocol version 6";
                    break;
                case 0x9000:
                    data2 = "used to test interfaces";
                    break;
                default:
                    break;
            }
            aFactoLabel.Add(new FactoLabel() { Name = "L2Protocol", Value = data2 });

            GroupBox aGroupBox = new GroupBox();
            aGroupBox.Location = new Point(30, 22);
            aGroupBox.Name = "GroupMAC";
            aGroupBox.Size = new Size(XMargin * 2 + XSize * 2 + XInterval, (YInterval + YSize) * aFactoLabel.Count + YMargin);
            int a = (YInterval + YSize) * aFactoLabel.Count + YMargin;
            aGroupBox.Text = "MAC Layer";

            for (int Count = 0; Count < aFactoLabel.Count; ++Count)
            {
                Label aLabel = new Label();
                aLabel.TextAlign = ContentAlignment.MiddleCenter;
                aLabel.Text = aFactoLabel[Count].Name;
                aLabel.Name = "****";
                aLabel.Size = new Size(XSize, YSize);
                aLabel.Location = new Point(XMargin, (YSize + YInterval) * Count + YMargin);
                aLabel.BorderStyle = BorderStyle.FixedSingle;
                aGroupBox.Controls.Add(aLabel);

                aLabel = new Label();
                aLabel.TextAlign = ContentAlignment.MiddleCenter;
                aLabel.Text = aFactoLabel[Count].Value;
                aLabel.Name = "****1";
                aLabel.Size = new Size(XSize, YSize);
                aLabel.Location = new Point(XMargin + XSize + XInterval, (YSize + YInterval) * Count + YMargin);
                aLabel.BorderStyle = BorderStyle.FixedSingle;
                aGroupBox.Controls.Add(aLabel);
            }

            Controls.Add(aGroupBox);



        }//1층
        private void Print_IP(byte[] IPData)
        {
            int XMargin = 10;
            int XSize = 120;
            int XInterval = 10;
            int YMargin = 15;
            int YSize = 20;
            int YInterval = 10;

            List<FactoLabel> aFactoLabel = new List<FactoLabel>();
            byte byteTemp = IPData[14];
            aFactoLabel.Add(new FactoLabel() { Name = "IP Version", Value = "IPv" + (byteTemp >> 4).ToString() });

            aFactoLabel.Add(new FactoLabel() { Name = "IP Head Length", Value = ((byteTemp & 0x0F) * 4).ToString() + " Bytes" });

            byteTemp = IPData[15];
            aFactoLabel.Add(new FactoLabel() { Name = "IP TOS", Value = string.Format("0x{0:X2}", byteTemp) });

            int iNum = BitConverter.ToUInt16(IPData.Skip<byte>(16).Take(2).Reverse().ToArray(), 0);
            aFactoLabel.Add(new FactoLabel() { Name = "IP Total Length", Value = iNum.ToString() + " Bytes" });

            iNum = BitConverter.ToUInt16(IPData.Skip<byte>(18).Take(2).Reverse().ToArray(), 0);
            aFactoLabel.Add(new FactoLabel() { Name = "IP IDentification", Value = iNum.ToString()});

            iNum = BitConverter.ToUInt16(IPData.Skip<byte>(20).Take(2).Reverse().ToArray(), 0);
            aFactoLabel.Add(new FactoLabel() { Name = "Fragment DF", Value = (0 != (iNum & (1 << 14))).ToString() });


            aFactoLabel.Add(new FactoLabel() { Name = "Fragment MF", Value = (0 != (iNum & (1 << 13))).ToString() });

            aFactoLabel.Add(new FactoLabel() { Name = "Fragment Offset", Value = (iNum & 0x1FFF).ToString() });

            byteTemp = IPData[22];
            aFactoLabel.Add(new FactoLabel() { Name = "Time To Live", Value = byteTemp.ToString() });

            byteTemp = IPData[23];
            string temp = "";
            switch (byteTemp)
            {
                case 0:
                    temp = "IPPROTO_IP";
                    break;
                case 1:
                    temp = "IPPROTO_ICMP";
                    break;
                case 2:
                    temp = "IPPROTO_IGMP";
                    break;
                case 4:
                    temp = "IPPROTO_IPIP";
                    break;
                case 6:
                    temp = "IPPROTO_TCP";
                    break;
                case 8:
                    temp = "IPPROTO_EGP";
                    break;
                case 12:
                    temp = "IPPROTO_PUP";
                    break;
                case 17:
                    temp = "IPPROTO_UDP";
                    break;
                case 22:
                    temp = "IPPROTO_IDP";
                    break;
                case 29:
                    temp = "IPPROTO_TP";
                    break;
                case 33:
                    temp = "IPPROTO_DCCP";
                    break;
                case 41:
                    temp = "IPPROTO_IPV6";
                    break;

                default:
                    break;
            }
            aFactoLabel.Add(new FactoLabel() { Name = "L3 Protocol", Value = temp });

            iNum = BitConverter.ToUInt16(IPData.Skip<byte>(24).Take(2).Reverse().ToArray(), 0);
            aFactoLabel.Add(new FactoLabel() { Name = "Checksum", Value = string.Format("0x{0:X4}", iNum) });

            IPAddress aiPAddress = new IPAddress(IPData.Skip<byte>(26).Take(4).ToArray());
            aFactoLabel.Add(new FactoLabel() { Name = "Source IP", Value = aiPAddress.ToString() });

            aiPAddress = new IPAddress(IPData.Skip<byte>(30).Take(4).ToArray());
            aFactoLabel.Add(new FactoLabel() { Name = "Destination IP", Value = aiPAddress.ToString() });

            GroupBox aGroupBox = new GroupBox();
            aGroupBox.Location = new Point(30, 142);
            aGroupBox.Name = "GroupIP";
            aGroupBox.Size = new Size(XMargin * 2 + XSize * 2 + XInterval, (YInterval + YSize) * aFactoLabel.Count + YMargin);//
            aGroupBox.Text = "IP Layer";


            for (int Count = 0; Count < aFactoLabel.Count; ++Count)
            {
                Label aLabel = new Label();
                aLabel.TextAlign = ContentAlignment.MiddleCenter;
                aLabel.Text = aFactoLabel[Count].Name;
                aLabel.Name = "****";
                aLabel.Size = new Size(XSize, YSize);
                aLabel.Location = new Point(XMargin, (YSize + YInterval) * Count + YMargin);
                aLabel.BorderStyle = BorderStyle.FixedSingle;
                aGroupBox.Controls.Add(aLabel);

                aLabel = new Label();
                aLabel.TextAlign = ContentAlignment.MiddleCenter;
                aLabel.Text = aFactoLabel[Count].Value;
                aLabel.Name = "****1";
                aLabel.Size = new Size(XSize, YSize);
                aLabel.Location = new Point(XMargin + XSize + XInterval, (YSize + YInterval) * Count + YMargin);
                aLabel.BorderStyle = BorderStyle.FixedSingle;
                aGroupBox.Controls.Add(aLabel);
            }
            Controls.Add(aGroupBox);


        }//2층


        private int Del_Button_Device(object sender)
        {
            int DeviceNum = Convert.ToInt32((sender as Button).Name.Substring("Facto".Length));
            CaptureDeviceList.Instance[DeviceNum].Open(DeviceMode.Normal, 0);

            for (int iTemp = 0; iTemp < CaptureDeviceList.Instance.Count; ++iTemp)
            {
                foreach (Control Temp in Controls)
                {
                    if (Temp.Name == ("Facto" + iTemp))
                    {
                        Controls.Remove(Temp);
                    }
                }
            }
            return DeviceNum;
        }
        private void Facto_Click(object sender, EventArgs e)
        {
            Del_Button_Device(sender);
            int DeviceNum = Convert.ToInt32((sender as Button).Name.Substring("Facto".Length));
            CaptureDeviceList.Instance[DeviceNum].Open(DeviceMode.Normal, 0);
            RawCapture aRawCapture = CaptureDeviceList.Instance[DeviceNum].GetNextPacket();
            Print_MAC(aRawCapture.Data);

            int iNum = BitConverter.ToInt16(aRawCapture.Data.Skip<byte>(12).Take(2).Reverse<byte>().ToArray(), 0);
            if (iNum== 0x0800)
            {
                Print_IP(aRawCapture.Data);//2계층출력
                if (6 == aRawCapture.Data[23])
                {
                    Print_TCP(aRawCapture.Data);
                }
            }

        }

        private void Print_TCP(byte[] Data)
        {
            // 변수 선언
            int XMargin = 10;
            int XSize = 120;
            int XInterval = 10;
            int YMargin = 15;
            int YSize = 20;
            int YInterval = 10;

            // Data 입력           
            List<FactoLabel> aFactoLabel = new List<FactoLabel>();

            aFactoLabel.Add(new FactoLabel() { Name = "L4 Protocol", Value = "" });
            int port1 =BitConverter.ToUInt16(Data.Skip<byte>(34).Take(2).Reverse().ToArray(), 0);
            int port2=BitConverter.ToUInt16(Data.Skip<byte>(36).Take(2).Reverse().ToArray(), 0);
            port1 = (port1 < 1024) ? port1 : 65535;
            port2 = (port2 < 1024) ? port2 : 65535;
            port1 = (port1 < port2) ? port1: port2;
            switch(port1)
            {
                case 7:
                    aFactoLabel[0].Value = "ECHO";
                    break;
                case 13:
                    aFactoLabel[0].Value = "DAYTIME";
                    break;
                case 20:
                    aFactoLabel[0].Value = "FTP-DATA";
                    break;
                case 21:
                    aFactoLabel[0].Value = "FTP-CONTROL";
                    break;
                case 22:
                    aFactoLabel[0].Value = "SSH";
                    break;
                case 23:
                    aFactoLabel[0].Value = "TELNET";
                    break;
                case 25:
                    aFactoLabel[0].Value = "SMTP";
                    break;
                case 37:
                    aFactoLabel[0].Value = "ECHO";
                    break;
                case 53:
                    aFactoLabel[0].Value = "DNS";
                    break;
                case 80:
                    aFactoLabel[0].Value = "HTTP";
                    break;
                case 443:
                    aFactoLabel[0].Value = "HTTPS";
                    break;
                default:
                    aFactoLabel[0].Value = "Not Support";
                    break;
                
            }

            UInt32 iNum = BitConverter.ToUInt16(Data.Skip<byte>(34).Take(2).Reverse().ToArray(), 0);
            aFactoLabel.Add(new FactoLabel() { Name = "Source Port", Value = iNum.ToString() });

            iNum = BitConverter.ToUInt16(Data.Skip<byte>(36).Take(2).Reverse().ToArray(), 0);
            aFactoLabel.Add(new FactoLabel() { Name = "Destination Port", Value = iNum.ToString() });

            iNum = BitConverter.ToUInt32(Data.Skip<byte>(38).Take(4).Reverse().ToArray(), 0);
            aFactoLabel.Add(new FactoLabel() { Name = "Sequence Number", Value = iNum.ToString() });

            iNum = BitConverter.ToUInt32(Data.Skip<byte>(42).Take(4).Reverse().ToArray(), 0);
            aFactoLabel.Add(new FactoLabel() { Name = "Ack Number", Value = iNum.ToString() });

            iNum = (UInt32)((Data[46] >> 4) * 4);
            aFactoLabel.Add(new FactoLabel() { Name = "Offset", Value = iNum.ToString() });

            iNum = Data[47];
            aFactoLabel.Add(new FactoLabel() { Name = "Bit:Urgent", Value = (0 != (iNum & 1 << 5)).ToString() });
            aFactoLabel.Add(new FactoLabel() { Name = "Bit:Ack", Value = (0 != (iNum & 1 << 4)).ToString() });
            aFactoLabel.Add(new FactoLabel() { Name = "Bit:Push", Value = (0 != (iNum & 1 << 3)).ToString() });
            aFactoLabel.Add(new FactoLabel() { Name = "Bit:Res", Value = (0 != (iNum & 1 << 2)).ToString() });
            aFactoLabel.Add(new FactoLabel() { Name = "Bit:Syn", Value = (0 != (iNum & 1 << 1)).ToString() });
            aFactoLabel.Add(new FactoLabel() { Name = "Bit:Fin", Value = (0 != (iNum & 1 << 0)).ToString() });

            iNum = BitConverter.ToUInt16(Data.Skip<byte>(48).Take(2).Reverse().ToArray(), 0);
            aFactoLabel.Add(new FactoLabel() { Name = "Windows Size", Value = iNum.ToString() });

            iNum = BitConverter.ToUInt16(Data.Skip<byte>(50).Take(2).Reverse().ToArray(), 0);
            aFactoLabel.Add(new FactoLabel() { Name = "Checksum", Value = string.Format("0x{0:X4}", iNum) });

            iNum = BitConverter.ToUInt16(Data.Skip<byte>(52).Take(2).Reverse().ToArray(), 0);
            aFactoLabel.Add(new FactoLabel() { Name = "Urgent Pointer", Value = string.Format("0x{0:X4}", iNum) });

            // 그룹박스 설정
            GroupBox aGroupBox = new GroupBox();
            aGroupBox.Location = new Point(315, 22);
            aGroupBox.Name = "GroupTCP";
            aGroupBox.Size = new Size(XMargin * 2 + XSize * 2 + XInterval, (YInterval + YSize) * aFactoLabel.Count + YMargin);
            aGroupBox.Text = "TCP Layer";

            // 라벨 설정
            for (int Count = 0; Count < aFactoLabel.Count; ++Count)
            {
                Label aLabel = new Label();
                aLabel.TextAlign = ContentAlignment.MiddleCenter;
                aLabel.Text = aFactoLabel[Count].Name;
                aLabel.Name = "****";
                aLabel.Size = new Size(XSize, YSize);
                aLabel.Location = new Point(XMargin, (YSize + YInterval) * Count + YMargin);
                aLabel.BorderStyle = BorderStyle.FixedSingle;
                aGroupBox.Controls.Add(aLabel);

                aLabel = new Label();
                aLabel.TextAlign = ContentAlignment.MiddleCenter;
                aLabel.Text = aFactoLabel[Count].Value;
                aLabel.Name = "****1";
                aLabel.Size = new Size(XSize, YSize);
                aLabel.Location = new Point(XMargin + XSize + XInterval, (YSize + YInterval) * Count + YMargin);
                aLabel.BorderStyle = BorderStyle.FixedSingle;
                aGroupBox.Controls.Add(aLabel);
            }
            // 그룹박스 출력
            Controls.Add(aGroupBox);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<string> NicName = new List<string>();
            foreach (ICaptureDevice Temp in CaptureDeviceList.Instance)
            {
                string[] arrTemp = Temp.ToString().Split('\n');
                NicName.Add(arrTemp[1].Substring("FriendlyName: ".Length));
            }

            for (int iTemp = 0; iTemp < NicName.Count; ++iTemp)
            {
                Button aButton = new Button();
                aButton.Text = NicName[iTemp];
                aButton.Name = "Facto" + iTemp;
                aButton.Location = new Point(30, 30 + iTemp * 30);
                aButton.Click += new EventHandler(Facto_Click);
                Controls.Add(aButton);
            }

            (sender as Button).Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Size = new Size(900, 700);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}