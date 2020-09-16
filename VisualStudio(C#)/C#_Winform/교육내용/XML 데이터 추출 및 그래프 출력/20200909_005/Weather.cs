using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200909_005
{
    class Weather
    {
        public string hour { get; set; }
        public string temp { get; set; }
        public string wfKor { get; set; }
        public string wdKor { get; set; }

        public override string ToString()
        {
            return string.Format($"{hour}시\t{temp}℃\t{wfKor}\t{wdKor}풍");
        }
    }
}
