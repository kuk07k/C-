using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _20200909_001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series[1].Points.Add(600);
            chart1.Series[1].Points.Add(900);
            chart1.Series[1].Points.Add(800);
            chart1.Series["수학"].Points.Add(200);
            chart1.Series["수학"].Points.Add(300);
            chart1.Series["수학"].Points.Add(600);

            chart1.Series["수학"].ChartType = SeriesChartType.Line; 
            chart1.Series[1].ChartType = SeriesChartType.Line; 

        }
    }
}
