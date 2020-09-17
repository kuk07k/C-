using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    // *** 라즈베리파이 온습도센서 모니터링 시스템 ***
    // IOT를 통해 MariaDB에 온습도센서(DHT11(Python) 데이터 저장
    // PC (C#)을 통한 UI 제작 (모니터링 시스템)
    // Chart, Mysql(Query문), Generic(List-Bind), Timer 사용
    // Form(디자인)에서 작업하는 것보다 코드로 작업하는것이 효율적(폼에서 작업을 한번 더해야하는 번거로움이 있음) 

    public partial class Form1 : Form
    {
        private static int DataSize = 300; // 300개를 읽어오겠다 (그래프에 몇개그릴지 결정하는 부분)
        private static string TName         = "tblsensorDHT11";
        private static string QueryLogin    = "SERVER=192.168.0.160; DATABASE=mydb; UID=root; PASSWORD=0000;";
        private static string QueryTable    = "SELECT * FROM " + TName + " ORDER BY TIME DESC LIMIT "; // LIMIT 30 : 처음부터 30개 // LIMIT 30 30 : 31번부터 30개
        private static string QueryTable12  = QueryTable + DataSize.ToString();
        private static string QueryTable1   = QueryTable + 1; // DB 쿼리 넣을때 띄어쓰기 꼭 해주기 !!!
        
        private bool TimerStartus;

        private void DataUpdate()
        {
            DataSet aDataSet = new DataSet();
            using (MySqlConnection aMySqlConnection = new MySqlConnection(QueryLogin))
            {
                MySqlDataAdapter aMySqlDataAdapter = new MySqlDataAdapter(QueryTable1, aMySqlConnection);
                aMySqlDataAdapter.Fill(aDataSet, TName);
            }
            DataRow Temp = aDataSet.Tables[TName].Rows[0];
            chart1.Series[0].Points.Add(Int32.Parse(Temp["TEMP"].ToString()));
            chart1.Series[1].Points.Add(Int32.Parse(Temp["HUMI"].ToString()));

            if (chart1.Series[0].Points.Count > DataSize) // Datasize 제한두고 업데이트
            {
                chart1.Series[0].Points.RemoveAt(0); // 제일 오랜된 데이터 제거
                chart1.Series[1].Points.RemoveAt(0);
            }
        }

        public void RefreshON()
        {
            TimerStartus = true;
            timer1.Start();
            button2.Text = "Graph Stop";
        }

        public void RefreshOFF()
        {
            TimerStartus = false;
            timer1.Stop();
            button2.Text = "Graph Start";
        }

        public void RefreshToggle()
        {
            if (false == TimerStartus) // 타이머가 꺼져 있을때
            {
                RefreshON();
            }
            else
            {
                RefreshOFF();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet aDataSet = new DataSet();
            using (MySqlConnection aMySqlConnection = new MySqlConnection(QueryLogin))
            {
                MySqlDataAdapter aMySqlDataAdapter = new MySqlDataAdapter(QueryTable12, aMySqlConnection);
                aMySqlDataAdapter.Fill(aDataSet, TName);
            }

            List<int> TempData = new List<int>();
            List<int> HumiData = new List<int>();
            foreach (DataRow Temp in aDataSet.Tables[TName].Rows)
            {
                TempData.Add(Int32.Parse(Temp["TEMP"].ToString()));
                HumiData.Add(Int32.Parse(Temp["HUMI"].ToString()));
            }
            //MessageBox.Show(TempData.Count.ToString());

            chart1.Series[0].Points.DataBindY(TempData);
            chart1.Series[1].Points.DataBindY(HumiData);

            RefreshON();
            button2.Text = "Graph Stop";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataUpdate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DataUpdate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshToggle();
        }
    }
}
