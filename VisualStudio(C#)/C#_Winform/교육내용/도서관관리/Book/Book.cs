using System;

namespace Book
{
    class Book
    {
        public string Isbn { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public int Page{ get; set; }

        public int UserID { get; set; }
        public string UserName { get; set; }
        public bool isBorrowed { get; set; }
        public DateTime BorrowedAT { get; set; }
    }
}
