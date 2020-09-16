using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MariaDB데이터를_WinForm에_출력
{
    public partial class Form1 : Form
    {
        string mode = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            mode = "UPDATE";

            SaveProcess();
            ClearTextControls();
            Reset();
        }

        private void New_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show(this, "빈값은 저장할 수 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            mode = "INSERT";

            SaveProcess();
            UpdateData();
            ClearTextControls();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show(this, "빈값은 삭제할 수 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DeleteProcess();
            UpdateData();
            ClearTextControls();
        }

        private void ClearTextControls()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }

        private void SaveProcess()
        {
            string strQuery = "SERVER=192.168.0.160;DATABASE=mydb;UID=root;PASSWORD=0000;";

            using (MySqlConnection conn = new MySqlConnection(strQuery))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                strQuery = "";

                if (mode == "UPDATE")
                {
                    strQuery = "UPDATE tblBook"
                               + " SET NAME = @NAME, Publisher = @Publisher, Page = @Page"
                               + " WHERE Isbn = @Isbn";
                }
                else if (mode == "INSERT")
                {
                    strQuery = "INSERT INTO tblBook (Isbn,NAME,Publisher,Page) "
                            + " VALUES(@Isbn, @NAME, @Publisher, @Page)";
                }
                cmd.CommandText = strQuery;

                MySqlParameter parm1 = new MySqlParameter("@Isbn", MySqlDbType.VarChar, 13);
                parm1.Value = textBox1.Text;
                cmd.Parameters.Add(parm1);

                MySqlParameter parm2 = new MySqlParameter("@NAME", MySqlDbType.VarChar, 30);
                parm2.Value = textBox2.Text;
                cmd.Parameters.Add(parm2);

                MySqlParameter parm3 = new MySqlParameter("@Publisher", MySqlDbType.VarChar, 7);
                parm3.Value = textBox3.Text;
                cmd.Parameters.Add(parm3);

                MySqlParameter parm4 = new MySqlParameter("@Page", MySqlDbType.VarChar, 4);
                parm4.Value = textBox4.Text;
                cmd.Parameters.Add(parm4);

                cmd.ExecuteNonQuery();
            }
        }

        private void UpdateData()
        {
            string strQuery = "SERVER=192.168.0.160;DATABASE=mydb;UID=root;PASSWORD=0000;";

            using (MySqlConnection conn = new MySqlConnection(strQuery))
            {
                conn.Open(); // DB 열기
                strQuery = "SELECT Isbn, NAME, Publisher, Page FROM tblBook ";
                //SqlCommand cmd = new SqlCommand(strQuery, conn);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "tblBook");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "tblBook";
            }
        }

        private void DeleteProcess()
        {
            string strQuery = "SERVER=192.168.0.160;DATABASE=mydb;UID=root;PASSWORD=0000;";

            using (MySqlConnection conn = new MySqlConnection(strQuery))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM tblBook "
                                + " WHERE Isbn = @Isbn";
                MySqlParameter parm1 = new MySqlParameter("@Isbn", MySqlDbType.VarChar, 13);
                parm1.Value = textBox1.Text;
                cmd.Parameters.Add(parm1);

                cmd.ExecuteNonQuery();
            }
        }

        private void Reset()
        {
            string strQuery = "SERVER=192.168.0.160;DATABASE=mydb;UID=root;PASSWORD=0000;";

            using (MySqlConnection conn = new MySqlConnection(strQuery))
            {
                conn.Open(); // DB 열기
                strQuery = "SELECT * FROM tblBook";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(strQuery, conn); // 명령 수행(sqlcommand 역할까지 수행)
                DataSet ds = new DataSet(); // 데이터를 담는통 (테이블)
                dataAdapter.Fill(ds, "tblBook"); // ds 통에다가 tblBook 이름으로 채운다

                dataGridView1.DataSource = ds; // dataGridView1에 붓는다
                dataGridView1.DataMember = "tblBook";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow data = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = data.Cells[0].Value.ToString();
                textBox2.Text = data.Cells[1].Value.ToString();
                textBox3.Text = data.Cells[2].Value.ToString();
                textBox4.Text = data.Cells[3].Value.ToString();

                mode = "UPDATE"; // 수정은 UPDATE
            }
        }
    }
}
