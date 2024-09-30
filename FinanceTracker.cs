using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2BIceTask3
{
    public class FinanceTracker
    {
        public List<Budget> Budgets { get; set; } = new List<Budget>();

        public void AddTransaction(int month, int year, Transaction transaction)
        {
            var budget = Budgets.FirstOrDefault(b => b.Month == month && b.Year == year);
            if (budget == null)
            {
                budget = new Budget { Month = month, Year = year };
                Budgets.Add(budget);
            }

            budget.Transactions.Add(transaction);
            if (transaction.Type == "Income")
                budget.ActualIncome += transaction.Amount;
            else
                budget.ActualExpenses += transaction.Amount;
        }

        public void SetBudget(int month, int year, double incomeGoal, double expenseLimit)
        {
            var budget = Budgets.FirstOrDefault(b => b.Month == month && b.Year == year);
            if (budget == null)
            {
                budget = new Budget { Month = month, Year = year };
                Budgets.Add(budget);
            }

            budget.IncomeGoal = incomeGoal;
            budget.ExpenseLimit = expenseLimit;
        }

        public double CalculateSavings(int month, int year)
        {
            var budget = Budgets.FirstOrDefault(b => b.Month == month && b.Year == year);
            if (budget != null)
            {
                return budget.ActualIncome - budget.ActualExpenses;
            }
            return 0;
        }

        // More methods like TrackProgress, IdentifyOverspending, PredictFutureSpending can be added here
    }

}
