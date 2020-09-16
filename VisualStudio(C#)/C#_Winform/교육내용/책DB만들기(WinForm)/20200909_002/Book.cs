using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200909_002
{
    class Book
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Book(string _name, int _Price)
        {
            Name = _name;
            Price = _Price;
        }
    }
}
