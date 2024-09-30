using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2BIceTask3
{
    public class Budget
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public double IncomeGoal { get; set; }
        public double ExpenseLimit { get; set; }
        public double ActualIncome { get; set; }
        public double ActualExpenses { get; set; }
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
