using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_select
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>() { 123, 45, 12, 89, 456, 1, 4, 74, 46, 100 };

            Print("Data : ", data);

            var lstEven = from item in data
                          where (item > 20 && item % 2 == 0)
                          orderby item descending
                          select item;

            Print("20보다 큰 짝수 검색결과 : ", lstEven);

            var lstSorted = from item in lstEven // 추출부분
                            orderby item ascending // 추출부분(ascending == 오름차순)
                            select item * 2; // 가공부분 (select를 통해 가공)

            Print("2를 곱해서 오름차순 정렬 : ", lstSorted);
        }

        private static void Print(string s, IEnumerable<int> data)
        {
            Console.WriteLine(s);
            foreach (var item in data)
                Console.Write(" " + item);
            Console.WriteLine();
        }
    }
}
