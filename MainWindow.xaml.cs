using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog2BIceTask3
{
    public partial class MainWindow : Window
    {
        private FinanceTracker _financeTracker = new FinanceTracker();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddTransaction_Click(object sender, RoutedEventArgs e)
        {
            var transaction = new Transaction
            {
                TransactionID = new Random().Next(1000, 9999), // Random Transaction ID
                Amount = double.Parse(TransactionAmount.Text),
                Date = TransactionDate.SelectedDate.Value,
                Type = (TransactionType.SelectedItem as ComboBoxItem).Content.ToString(),
                Category = (TransactionCategory.SelectedItem as ComboBoxItem).Content.ToString(),
                Description = "Transaction Details"
            };

            _financeTracker.AddTransaction(transaction.Date.Month, transaction.Date.Year, transaction);
            MessageBox.Show("Transaction Added!");
        }

        private void SetBudget_Click(object sender, RoutedEventArgs e)
        {
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            double incomeGoal = double.Parse(IncomeGoalInput.Text);
            double expenseLimit = double.Parse(ExpenseLimitInput.Text);

            _financeTracker.SetBudget(month, year, incomeGoal, expenseLimit);
            MessageBox.Show("Budget Set!");
        }

        private void OpenReportWindow_Click(object sender, RoutedEventArgs e)
        {
            ReportWindow reportWindow = new ReportWindow(_financeTracker);
            reportWindow.Show();
        }
    }

}