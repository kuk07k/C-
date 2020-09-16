using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SharpPcap;
using System.Net;

namespace _20200826_001
{
    // 1. 설치 - 캡쳐 - 목록 - 선택 - 오픈 - 캡쳐
    // 2. 캡쳐된 것을 요리하는 과정

    // 네트워크 프로토콜을 분석
    // UI 제작(WinForm)
    // C# 사용(Linq, List, generic, 별도의 라이브러리 추가)

    // L1 : Ethernet
    // L2 : IP
    // L3 : TCP/UDP

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

            for (int iTemp = 0; iTemp < NicName.Count; iTemp++)
            {
                Button abutton = new Button();
                abutton.Text = NicName[iTemp];
                abutton.Name = "Facto" + iTemp;
                abutton.Location = new Point(10, 10 + iTemp * 40);
                abutton.Size = new Size(200, 30);
                abutton.BackColor = Color.White;
                abutton.Click += new EventHandler(Facto_Click);
                Controls.Add(abutton);
            }
            (sender as Button).Enabled = false;
        }

        private int Del_Button_Device(object sender)
        {
            int DeviceNum = Convert.ToInt32((sender as Button).Name.Substring("Facto".Length));
            
            for (int iTemp = 0; iTemp < CaptureDeviceList.Instance.Count; iTemp++)
            {
                foreach (Control Temp in Controls) // controls라는 집합안에 버튼이 속해있음
                {
                    if (Temp.Name == ("Facto" + iTemp))
                    {
                        Controls.Remove(Temp);
                    }
                }
            }
            return DeviceNum;
        }

        private void Print_TCP(byte[] EtherData)
        {
            int XMargin = 10;
            int XSize = 120;
            int XInterval = 10;
            int YMargin = 15;
            int YSize = 20;
            int YInterval = 10;

            // 데이터 입력
            // TCP 헤더
            List<FactoLabel> afactoLabels = new List<FactoLabel>();

            afactoLabels.Add(new FactoLabel() { Name = "L4 Protocol", Value = "" });
            int port1 = BitConverter.ToUInt16(EtherData.Skip<byte>(34).Take(2).Reverse().ToArray(), 0);
            int port2 = BitConverter.ToUInt16(EtherData.Skip<byte>(36).Take(2).Reverse().ToArray(), 0);
            port1 = (port1 < 1024) ? port1 : 65535;
            port2 = (port2 < 1024) ? port2 : 65535;
            port1 = (port1 < port2) ? port1 : port2;
            switch (port1)
            {
                case 7:
                    afactoLabels[0].Value = "ECHO";
                    break;
                case 13:
                    afactoLabels[0].Value = "DAYTIME";
                    break;
                case 20:
                    afactoLabels[0].Value = "FTP : Data";
                    break;
                case 21:
                    afactoLabels[0].Value = "FTP : Control";
                    break;
                case 22:
                    afactoLabels[0].Value = "Secure SHell";
                    break;
                case 23:
                    afactoLabels[0].Value = "Telnet Protocol";
                    break;
                case 25:
                    afactoLabels[0].Value = "SMTP";
                    break;
                case 37:
                    afactoLabels[0].Value = "TIME Protocol";
                    break;
                case 53:
                    afactoLabels[0].Value = "DNS";
                    break;
                case 80:
                    afactoLabels[0].Value = "HTTP";
                    break;
                case 443:
                    afactoLabels[0].Value = "HTTPS";
                    break;
                default:
                    afactoLabels[0].Value = "Not Support";
                    break;
            }

            UInt32 iNum = BitConverter.ToUInt16(EtherData.Skip<byte>(34).Take(2).Reverse().ToArray(), 0);
            afactoLabels.Add(new FactoLabel() { Name = "Port Source", Value = iNum.ToString() });

            iNum = BitConverter.ToUInt16(EtherData.Skip<byte>(36).Take(2).Reverse().ToArray(), 0);
            afactoLabels.Add(new FactoLabel() { Name = "Destination Port", Value = iNum.ToString() });

            iNum = BitConverter.ToUInt32(EtherData.Skip<byte>(38).Take(4).Reverse().ToArray(), 0);
            afactoLabels.Add(new FactoLabel() { Name = "Sequence Number", Value = iNum.ToString() });

            iNum = BitConverter.ToUInt32(EtherData.Skip<byte>(42).Take(4).Reverse().ToArray(), 0);
            afactoLabels.Add(new FactoLabel() { Name = "Ack Number", Value = iNum.ToString() });

            iNum = (uint)(EtherData[46]>>4) * 4;
            afactoLabels.Add(new FactoLabel() { Name = "Offset", Value = iNum.ToString() });

            iNum = EtherData[47];
            
            afactoLabels.Add(new FactoLabel() { Name = "Bit:Urgent" , Value = (0 != (iNum & 1 << 5)).ToString() });
            afactoLabels.Add(new FactoLabel() { Name = "Bit:Ack"    , Value = (0 != (iNum & 1 << 5)).ToString() });
            afactoLabels.Add(new FactoLabel() { Name = "Bit:Push"   , Value = (0 != (iNum & 1 << 5)).ToString() });
            afactoLabels.Add(new FactoLabel() { Name = "Bit:Res"    , Value = (0 != (iNum & 1 << 5)).ToString() });
            afactoLabels.Add(new FactoLabel() { Name = "Bit:Syn"    , Value = (0 != (iNum & 1 << 5)).ToString() });
            afactoLabels.Add(new FactoLabel() { Name = "Bit:Fin"    , Value = (0 != (iNum & 1 << 5)).ToString() });

            iNum = BitConverter.ToUInt16(EtherData.Skip<byte>(48).Take(2).Reverse().ToArray(), 0);
            afactoLabels.Add(new FactoLabel() { Name = "Window Size", Value = iNum.ToString() });

            iNum = BitConverter.ToUInt16(EtherData.Skip<byte>(50).Take(2).Reverse().ToArray(), 0);
            afactoLabels.Add(new FactoLabel() { Name = "Check Sum", Value = string.Format("0x{0:X4}",iNum)});

            iNum = BitConverter.ToUInt16(EtherData.Skip<byte>(52).Take(2).Reverse().ToArray(), 0);
            afactoLabels.Add(new FactoLabel() { Name = "Urgent Pointer", Value = string.Format("0x{0:X4}", iNum) });

            // 그룹박스 설정
            GroupBox groupBox = new GroupBox();
            groupBox.Location = new Point(300, 10);
            groupBox.Name = "Group TCP";
            groupBox.Size = new Size(XMargin * 2 + XSize * 2 + XInterval, YMargin + (YInterval + YSize) * afactoLabels.Count);
            groupBox.Text = "TCP Layer";

            // 라벨 설정
            for (int Count = 0; Count < afactoLabels.Count; ++Count)
            {
                Label aLabel = new Label();
                aLabel.TextAlign = ContentAlignment.MiddleCenter;
                aLabel.Text = afactoLabels[Count].Name;
                aLabel.Name = "****";
                aLabel.Size = new Size(XSize, YSize);
                aLabel.Location = new Point(XMargin, (YSize + YInterval) * Count + YMargin);
                aLabel.BorderStyle = BorderStyle.FixedSingle;
                aLabel.BackColor = Color.LightGray;
                groupBox.Controls.Add(aLabel);

                aLabel = new Label();
                aLabel.TextAlign = ContentAlignment.MiddleCenter;
                aLabel.Text = afactoLabels[Count].Value;
                aLabel.Name = "****1";
                aLabel.Size = new Size(XSize, YSize);
                aLabel.Location = new Point(XMargin + XSize + XInterval, (YSize + YInterval) * Count + YMargin);
                aLabel.BorderStyle = BorderStyle.FixedSingle;
                groupBox.Controls.Add(aLabel);
            }

            // 그룹박스 출력
            Controls.Add(groupBox);
        } 

        private void Print_MAC(byte [] EtherData)
        {

            Label aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "Destination MAC";
            aLabel.Name = "LabelDMAC";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(10, 10);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.BackColor = Color.LightGray;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "Source MAC";
            aLabel.Name = "LabelSMAC";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(10, 40);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.BackColor = Color.LightGray;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "L2 Protocal";
            aLabel.Name = "LabelProto";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(10, 70);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.BackColor = Color.LightGray;
            Controls.Add(aLabel);

            string data = string.Format("{0:X2}", EtherData[0]);
            for (int iTemp = 1; iTemp < 6; ++iTemp)
            {
                data += string.Format("-{0:X2}", EtherData[iTemp]);
            }
            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleLeft;
            aLabel.Text = data;
            aLabel.Name = "LabelDMACData";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(140, 10);
            Controls.Add(aLabel);

            data = string.Format("{0:X2}", EtherData[6]);
            for (int iTemp = 7; iTemp < 12; ++iTemp)
            {
                data += string.Format("-{0:X2}", EtherData[iTemp]);
            }
            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleLeft;
            aLabel.Text = data;
            aLabel.Name = "LabelSMACData";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(140, 40);
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleLeft;
            int iNum = BitConverter.ToUInt16(EtherData.Skip<byte>(12).Take(2).Reverse<byte>().ToArray(), 0);
            switch (iNum)
            {
                case 0x0800:
                    data = "IP";
                    break;
                case 0x0200:
                    data = "Xerox PUP";
                    break;
                case 0x0500:
                    data = "Sprite";
                    break;
                case 0x0806:
                    data = "Address resolution";
                    break;
                case 0x8035:
                    data = "Reverse ARP";
                    break;
                case 0x809B:
                    data = "AppleTalk protocol";
                    break;
                case 0x80F3:
                    data = "AppleTalk ARP";
                    break;
                case 0x8100:
                    data = "IEEE 802.1Q VLAN tagging";
                    break;
                case 0x8137:
                    data = "IPX";
                    break;
                case 0x86dd:
                    data = "IP protocol version 6";
                    break;
                case 0x9000:
                    data = "used to test interfaces";
                    break;
                default:
                    data = "Unknown";
                    break;
            }
            aLabel.Text = data;
            aLabel.Name = "LabelProtoData";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(140, 70);
            Controls.Add(aLabel);
        }

        private void Print_IP(byte[] IPData)
        {
            Label aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "IP Version";
            aLabel.Name = "LabelIPV";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(10, 100);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.BackColor = Color.LightGray;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "IP Head Length";
            aLabel.Name = "LabelIPHL";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(10, 130);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.BackColor = Color.LightGray;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "IP TOS";
            aLabel.Name = "LabelIPTOS";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(10, 160);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.BackColor = Color.LightGray;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "IP Total Length";
            aLabel.Name = "LabelIPTOL";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(10, 190);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.BackColor = Color.LightGray;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "IP Identification";
            aLabel.Name = "LabelIDTF";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(10, 220);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.BackColor = Color.LightGray;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "Fragment DF";
            aLabel.Name = "LableFrag DF";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(10, 250);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.BackColor = Color.LightGray;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "Fragment MF";
            aLabel.Name = "LableFrag MF";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(10, 270);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.BackColor = Color.LightGray;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "Fragment Offset";
            aLabel.Name = "LableFrag Offset";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(10, 290);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.BackColor = Color.LightGray;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "Time To Live";
            aLabel.Name = "LableTTL";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(10, 320);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.BackColor = Color.LightGray;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "L3 Protocol";
            aLabel.Name = "LabelIPPROTO";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(10, 350);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.BackColor = Color.LightGray;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "Header Checksum";
            aLabel.Name = "LabelHeadCheck";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(10, 380);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.BackColor = Color.LightGray;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "Source IP";
            aLabel.Name = "LabelSouIP";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(10, 410);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.BackColor = Color.LightGray;
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleCenter;
            aLabel.Text = "Destination IP";
            aLabel.Name = "LabelDesIP";
            aLabel.Size = new Size(120, 20);
            aLabel.Location = new Point(10, 440);
            aLabel.BorderStyle = BorderStyle.FixedSingle;
            aLabel.BackColor = Color.LightGray;
            Controls.Add(aLabel);

            // Version, IHL(14)
            byte byteTemp = IPData[14];

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleLeft;
            aLabel.Text = "IPv" + (byteTemp >> 4).ToString();
            aLabel.Name = "LabelIPVData";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(140, 100);
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleLeft;
            aLabel.Text = ((byteTemp & 0x0F) * 4).ToString() + " Bytes";
            aLabel.Name = "LabelIPHLData";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(140, 130);
            Controls.Add(aLabel);

            // TOS(15)
            byteTemp = IPData[15];

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleLeft;
            aLabel.Text = string.Format("0x{0:X2}", byteTemp);
            aLabel.Name = "LabelIPTOSData";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(140, 160);
            Controls.Add(aLabel);

            // Total Length(16, 17)
            int iNum = BitConverter.ToUInt16(IPData.Skip<byte>(16).Take(2).Reverse<byte>().ToArray(), 0);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleLeft;
            aLabel.Text = iNum.ToString() + " Bytes";
            aLabel.Name = "LabelIPTOL";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(140, 190);
            Controls.Add(aLabel);

            // Identification(18, 19)
            iNum = BitConverter.ToUInt16(IPData.Skip<byte>(18).Take(2).Reverse<byte>().ToArray(), 0);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleLeft;
            aLabel.Text = iNum.ToString();
            aLabel.Name = "LabelIDTIF";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(140, 220);
            Controls.Add(aLabel);

            // DF(분할할 수 없는 패킷), MF, Fragment Offset
            iNum = BitConverter.ToUInt16(IPData.Skip<byte>(20).Take(2).Reverse().ToArray(), 0);
            
            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleLeft;
            aLabel.Text = (0 != (iNum & (1 << 14))).ToString();
            aLabel.Name = "Fragment DF";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(140, 250);
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleLeft;
            aLabel.Text = (0 != (iNum & (1 << 13))).ToString();
            aLabel.Name = "Fragment MF";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(140, 270);
            Controls.Add(aLabel);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleLeft;
            aLabel.Text = (iNum&0x1FFF).ToString();
            aLabel.Name = "Fragment Offset";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(140, 290);
            Controls.Add(aLabel);

            // TTL(22)
            byteTemp = IPData[22];

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleLeft;
            aLabel.Text = byteTemp.ToString();
            aLabel.Name = "LableTTL";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(140, 320);
            Controls.Add(aLabel);


            // L3Proto(23)
            byteTemp = IPData[23];

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleLeft;

            aLabel.Text = "";
            switch (byteTemp)
            {
                case 0:
                    aLabel.Text = "IP";
                    break;
                case 1:
                    aLabel.Text = "ICMP";
                    break;
                case 2:
                    aLabel.Text = "IGMP";
                    break;
                case 4:
                    aLabel.Text = "IPIP";
                    break;
                case 6:
                    aLabel.Text = "TCP";
                    break;
                case 8:
                    aLabel.Text = "EGP";
                    break;
                case 12:
                    aLabel.Text = "PUP";
                    break;
                case 17:
                    aLabel.Text = "UDP";
                    break;
                case 22:
                    aLabel.Text = "IDP";
                    break;
                case 29:
                    aLabel.Text = "TP";
                    break;
                case 33:
                    aLabel.Text = "DCCP";
                    break;
                case 41:
                    aLabel.Text = "IPV6";
                    break;
                default:
                    aLabel.Text = "Unknown";
                    break;
            }

            aLabel.Name = "LabelIPPROTO";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(140, 350);
            Controls.Add(aLabel);

            // HeadCheck(24)
            iNum = BitConverter.ToUInt16(IPData.Skip<byte>(24).Take(2).Reverse().ToArray(), 0);

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleLeft;
            aLabel.Text = string.Format("0x{0:X4}", iNum);
            aLabel.Name = "LabelHeadCheck";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(140, 380);
            Controls.Add(aLabel);

            // Source(26)
            IPAddress aiPAddress = new IPAddress(IPData.Skip<byte>(26).Take(4).ToArray());

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleLeft;
            aLabel.Text = aiPAddress.ToString();
            aLabel.Name = "Source IP";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(140, 410);
            Controls.Add(aLabel);

            // Destination(30)
            aiPAddress = new IPAddress(IPData.Skip<byte>(30).Take(4).ToArray());

            aLabel = new Label();
            aLabel.TextAlign = ContentAlignment.MiddleLeft;
            aLabel.Text = aiPAddress.ToString();
            aLabel.Name = "Destination IP";
            aLabel.Size = new Size(140, 20);
            aLabel.Location = new Point(140, 440);
            Controls.Add(aLabel);

        }

        private void Facto_Click(object sender, EventArgs e)
        {
            int DeviceNum = Del_Button_Device(sender);
            CaptureDeviceList.Instance[DeviceNum].Open(DeviceMode.Normal, 0);
            RawCapture arawCapture = CaptureDeviceList.Instance[DeviceNum].GetNextPacket();// 패킷을 하나가져오는 과정
            Print_MAC(arawCapture.Data); // 1계층 출력

            int iNum = BitConverter.ToUInt16(arawCapture.Data.Skip<byte>(12).Take(2).Reverse<byte>().ToArray(), 0);
            if (0x0800 == iNum) // IP 패킷일때
            {
                Print_IP(arawCapture.Data);// 2계층 출력

                if (6 == arawCapture.Data[23]) // TCP 패킷일때
                {
                    Print_TCP(arawCapture.Data); // 3계층 출력
                }
            }
        }
    }
}
