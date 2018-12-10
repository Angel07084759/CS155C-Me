/// Chapter No. Week7	Exercise No. Lab1
/// File Name:          MainWindow.xaml.cs
/// @author:            Angel Tapia
/// Date:               October 1, 2018
/// Problem Statement:  This GUI is a simple calculator that is capable to 
///                     perform additions, subtractions, multiplications, 
///                     divisions, and modulars operations. 
/// Algorithm:
/// 1) Create constants for operators:
///     public const char ADD = '+', SUB = '-', MUL = '*', DIV = '/', MOD = '%';
/// 2) Implement MainWindows:
///     Add items (operators: ADD, SUB, etc.) to the operator list box added to the GUI.
///     Select default operator index: operatorListBox.SelectedIndex = 0;
/// 3) Implement convert_Click():
///     Create local variables:
///         double lhsValue = 0;
///         double rhsValue = 0;
///         double result = 0;
///     Clear the output textBox: output.Text = "";
///     Create a try catch block to perform the calculator selected operation:
///         try:
///             Parse left hand side value and right side value
///             If Division or Modular operator is selected: Show MessageBox: ERROR Division by '0'
///             Else Create a switch statement to perform the selected operation.
///                 switch (operatorListBox.SelectedItem)
///                     case ADD: 
///                         result = lhsValue + rhsValue;
///                         break;
///                         ....
///                 Show result: output.Text = "" + result;
///         catch: 
///             Show MessageBox: Invalid input!!
///             Clear all inputs and outputs
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

namespace Week7_Lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Constants fro operators.
        public const char ADD = '+', SUB = '-', MUL = '*', DIV = '/', MOD = '%';

        public MainWindow()
        {
            InitializeComponent();
            //Add items to list box
            operatorListBox.Items.Add(ADD);
            operatorListBox.Items.Add(SUB);
            operatorListBox.Items.Add(MUL);
            operatorListBox.Items.Add(DIV);
            operatorListBox.Items.Add(MOD);
            //Select an default element
            operatorListBox.SelectedIndex = 0;

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void operatorListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void convert_Click(object sender, RoutedEventArgs e)
        {

            //Local variables
            double lhsValue = 0;
            double rhsValue = 0;
            double result = 0;

            //Clear output
            output.Text = "";

            try
            {
                //Convert string to numerical values
                lhsValue = Convert.ToDouble(lhs.Text.Trim());
                rhsValue = Convert.ToDouble(rhs.Text.Trim());

                //Error checking: division by '0'
                if ((operatorListBox.SelectedItem.Equals(DIV) || operatorListBox.SelectedItem.Equals(MOD)) && rhsValue == 0)
                {
                    MessageBox.Show("ERROR: Division by '0'");

                }
                else//Perform operation
                {
                    switch (operatorListBox.SelectedItem)
                    {
                        case ADD:
                            result = lhsValue + rhsValue;
                            break;
                        case SUB:
                            result = lhsValue - rhsValue;
                            break;
                        case MUL:
                            result = lhsValue * rhsValue;
                            break;
                        case DIV:
                            result = lhsValue / rhsValue;
                            break;
                        case MOD:
                            result = lhsValue % rhsValue;
                            break;
                    }
                    //Show result
                    output.Text = "" + result;
                }
            }
            catch (Exception)//Catch exceptions
            {

                MessageBox.Show("Invalid Input!!!");
                lhs.Text = "";
                rhs.Text = "";
                output.Text = "";
            }
            finally
            {
                //Release resources
            }
        }
    }
}
