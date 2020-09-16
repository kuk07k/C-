using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200909_006
{
    /// <summary>
    /// 데이터베이스에서 데이터 들고오기
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            DataSet adataSet = new DataSet();
            string Query = "SERVER=192.168.0.160; DATABASE=mydb; UID=root; PASSWORD=0000";

            // using은 {}안에서 작업을 실행하고 }에서 나간다.
            // 접속하고 바로 나갈땐 using을 사용하면 유용
            using (MySqlConnection amySqlConnection = new MySqlConnection(Query)) // 데이터베이스 접속부분
            {
                Query = "SELECT * FROM tblRegister";
                MySqlDataAdapter amySqlData = new MySqlDataAdapter(Query, amySqlConnection);
                amySqlData.Fill(adataSet, "tblRegister");
                //amySqlConnection.Close();
            }

            DataRow adataRow;
            adataRow = adataSet.Tables["tblRegister"].Rows[0]; // tblRegister테이블의 첫번째 줄을 가져와라.
            Console.WriteLine("전체 레코드 개수 : " + adataSet.Tables["tblRegister"].Rows.Count);
            Console.WriteLine(adataRow["name"] + ":" + adataRow["num2"]);

            adataRow = adataSet.Tables[0].Rows[1]; // 2번라인
            Console.WriteLine(adataRow[2] + ":" + adataRow[4]); // 2번라인의 요소 출력

        }
    }
}
