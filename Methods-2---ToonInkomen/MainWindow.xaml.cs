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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Methods_2___ToonInkomen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Void-methode
        private void ShowIncome(int yearSalary, int numberOfYears)
        {
            int income = yearSalary * numberOfYears;
            totalIncomeTextBox.Text = $"{income:c}";
        }

        // Function-methode die resultaat teruggeeft
        private int ShowIncomeWithReturnValue(int yearSalary, int numberOfYears)
        {
            return yearSalary * numberOfYears;
        }

        // Void-methode met out parameter
        private void ShowIncomeWithOutParam(int yearSalary, int years, out int income)
        {
            income = yearSalary * years;
        }

        // Void-methode met ref parameter
        private void ShowIncomeWithRefParam(int yearSalary, int years, ref int income)
        {
            income = yearSalary * years;
        }

        private void showIncomeButton_Click(object sender, RoutedEventArgs e)
        {
            // Void-methode
            int yearSalary = int.Parse(yearSalaryTextBox.Text);
            int numberOfYears = int.Parse(numberOfYearsTextBox.Text);
            ShowIncome(yearSalary, numberOfYears);

            // Function-methode die resultaat teruggeeft
            int income1 = ShowIncomeWithReturnValue(yearSalary, numberOfYears);
            totalIncomeTextBox.Text = $"{income1:c}";

            // Void-methode met out parameter
            int income2;
            ShowIncomeWithOutParam(yearSalary, numberOfYears, out income2);
            totalIncomeTextBox.Text = $"{income2:c}";

            // Void-methode met ref parameter
            int income3 = 0;
            ShowIncomeWithRefParam(yearSalary, numberOfYears, ref income3);
            totalIncomeTextBox.Text = $"{income3:c}";

            yearSalaryTextBox.Focus();
        }
    }
}
