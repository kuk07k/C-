using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200910
{
    /// <summary>
    /// 콘솔앱에서 레코드를 1개 추가하고 이를 다시 읽어 들여 출력하는 콘솔앱 작성
    /// </summary>
    
    class Program
    {
        static void Main(string[] args)
        {
            string Query = "SERVER=192.168.0.160;DATABASE=mydb;UID=root;PASSWORD=0000;";

            using (MySqlConnection aMySqlConnection = new MySqlConnection(Query))
            {
                aMySqlConnection.Open();

                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = "SERVER=192.168.0.160;DATABASE=mydb;UID=root;PASSWORD=0000;";

                //테이블 생성
                //MySqlCommand cmd = new MySqlCommand();
                //cmd.Connection = conn;
                //cmd.CommandText = "create table tblBook2(ISBN int, name nvarchar(40), Publisher nvarchar(20), Page int);";
                //cmd.ExecuteNonQuery();
                //MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                //DataSet ds = new DataSet();
                //da.Fill(ds);  

                // 테이블에 값 추가
                //Query = "INSERT INTO tblBook VALUES (9788998756277, 'ITCookBook HTML5 웹 프로그래밍 입문', '한빛아카데미', 440)," +
                //                                     " (9791185890104, '소셜 코딩으로 이끄는 GitHub 실천 기술', '제이펍', 356)," +
                //                                     " (9788968481901, 'Nature of Code', '한빛미디어', 620)," +
                //                                     " (9788968480553, 'TopCoder 탑코더 알고리즘 트레이닝', '한빛미디어', 492)," +
                //                                     " (9788998756260, 'ITCookBook 정보 보안 개론', '한빛아카데미', 596)," +
                //                                     " (9791156641209, 'ITCookBook 우분투 리눅스', '한빛미디어', 772)";

            }
        }
    }
}