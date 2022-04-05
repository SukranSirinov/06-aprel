using System;
using System.Collections.Generic;
using System.Text;

namespace _04062022
{
    internal class Order
    {
        static int _no;
        public string No { get;  }
        public int ProductCount { get; set; }
        public int TotalAmout { get; set; }
        public DateTime CreatedAt { get; set; } 
        
    }
}
