using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2BIceTask3
{
  
    public class Transaction
    {
        public int TransactionID { get; set; }
        public double Amount { get; set; }
        public DateTime Date {  get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
    }
}
