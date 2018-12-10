/// Chapter No. Week4	Exercise No. Homework3_1
/// File Name:          MainWindow.xaml.cs
/// @author:            Angel Tapia
/// Date:               September 11, 2018
///
/// Problem Statement:  This GUI program Calculates the amount of
///                     money that goes to the principal and to 
///                     the interest of a mortage payment.
/// Overall Plan:
/// 1) Declare Constant ANNUAL_INTEREST_RATE for the interest rate.
/// 2) Implement enter_click method to calculate and display result
///    on the GUI program:
///     -Declare local variables:
///         String balanceIn, to get the balance from the user.
///         String paymentIn = to get the amount of payment from the user.
///     -Clear error message
///     -Parse input or display error if any:
///         if empty text box: Please complete all of the fields!
///         else if imput = 0: "0" is not allowed!
///         else if non-numerical: Please enter numerical values only!
///         else calculate and display results:
///             interest = balance * ANNUAL_INTEREST_RATE / 12.0;
///             principal = payment - interest;
///             principal.Text = String.Format("{0:C}", principal);
///             interest.Text = String.Format("{0:C}", interest);
/// 
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

namespace Homework3_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //constant for the interest rate
        public const double ANNUAL_INTEREST_RATE = 0.0639;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            // inputs from the user
            String balanceIn = balance.Text.Trim();
            String paymentIn = payment.Text.Trim();

            errorMsg.Content = "";//error message

            //Parse input from the user
            Double.TryParse(balanceIn, out double balance2Double);
            Double.TryParse(paymentIn, out double payment2Double);

            //Error checking: empty strings, zero, or nonnumerical values
            if (balanceIn.Length == 0 || paymentIn.Length == 0)
            {
                errorMsg.Content = "Please complete all of the fields!";
            }
            else if (balanceIn.Equals("0") || paymentIn.Equals("0"))
            {
                errorMsg.Content = "\"0\" is not allowed!";
            }
            else if (balance2Double == 0 || payment2Double == 0)
            {
                errorMsg.Content = "Please enter numerical values only!";
            }
            else//Calculate valid inputs
            {
                double toInterest = balance2Double * ANNUAL_INTEREST_RATE / 12.0;
                double toPrincipal = payment2Double - toInterest;
                principal.Text = String.Format("{0:C}", toPrincipal);
                interest.Text = String.Format("{0:C}", toInterest);
            }
        }

        private void principal_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
