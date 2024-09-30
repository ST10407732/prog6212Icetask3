using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Prog2BIceTask3
{
    public partial class ReportWindow : Window
    {
        private FinanceTracker _financeTracker;

        public ReportWindow(FinanceTracker financeTracker)
        {
            InitializeComponent();
            _financeTracker = financeTracker;
        }

        private void GenerateReport_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected month
            int selectedMonth = MonthSelector.SelectedIndex + 1; // Months are 1-based in DateTime
            int year = DateTime.Now.Year; // Assume the current year

            // Find the budget for the selected month and year
            var budget = _financeTracker.Budgets.FirstOrDefault(b => b.Month == selectedMonth && b.Year == year);

            if (budget != null)
            {
                // Display total income, total expenses, and savings
                TotalIncomeText.Text = budget.ActualIncome.ToString("C");
                TotalExpensesText.Text = budget.ActualExpenses.ToString("C");
                SavingsText.Text = (budget.ActualIncome - budget.ActualExpenses).ToString("C");

                // Bind the list of transactions for the selected month
                TransactionListView.ItemsSource = budget.Transactions;
            }
            else
            {
                MessageBox.Show("No data available for the selected month.");
            }
        }
    }

}
