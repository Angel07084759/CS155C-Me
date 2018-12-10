/// Chapter No. Week5	Exercise No. Homework4_1
/// File Name:          MainWindow.xaml.cs
/// @author:            Angel Tapia
/// Date:               September 24, 2018
///
/// Problem Statement:  This GUI program Calculates Body Mass Index 
///                     with a given weight (in pounds) and height (in inches).
/// Overall Plan:
/// 1) Declare Constant for healthy range:
///     public const int HEALTHY_RANGE_MIN = 15;
///     public const int HEALTHY_RANGE_MAX = 26;
/// 2) Implement Button_Click:
///     -Create local variable for result:
///         double resultBMI = 0.0; to store BMI results
///         bool foundError = false; to check for input errors
///     -Set up main canvas color to default value (white)
///      and clear result label = "".
///     -Get weight and height from the user as strings.
///     -Parse weight and height to double values.
///     -Check and display empty text box if weight or 
///      height is empty, and foundError = true.
///     -Check and display if user enter a '0' as a value, 
///      and foundError = true.
///     -if no error found:
///         Calculate BMI with the given formula.
///         if Above healthy range:
///             change canvas color to yellow and display above range.
///         else if below healthy range:
///             change canvas color to blue and display below range.
///         else: change canvas color to green and display within range.

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

namespace Homework4_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Constants for healthy range
        public const int HEALTHY_RANGE_MIN = 15;
        public const int HEALTHY_RANGE_MAX = 26;
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Create local variable for result
            double resultBMI = 0.0;
            bool foundError = false;

            //Set up main canvas color to default value and clear result label.
            canvas_main.Background = Brushes.White;
            label_result.Content = "";

            //Get weight and height from the user.
            String weightStr = textbox_weight.Text.Trim();
            String heightStr = textbox_height.Text.Trim();

            //Parse weight and height to double values.
            Double.TryParse(weightStr, out double weight);
            Double.TryParse(heightStr, out double height);

            //Check and display empty text box if weight or height is empty, and foundError = true.
            if (weightStr.Length == 0 || heightStr.Length == 0)
            {
                label_result.Content = "Please fill all of the fields!";
                foundError = true;
            }

            //Check and display if user enter a '0' as a value, and foundError = true.
            if (weight == 0 || height == 0)
            {
                label_result.Content = "'0' is not allowed!";
                foundError = true;
            }
            
            // if no error found
            if (!foundError)
            {
                //Calculate BMI with the given formula
                resultBMI = (weight * 720) / (height * height);// 720?

                //Above healthy range.
                if (resultBMI > HEALTHY_RANGE_MAX)
                {
                    canvas_main.Background = Brushes.Yellow;
                    label_result.Content = String.Format( "[BMI: {0:0.0}] You are above the healthy range!", resultBMI);
                }//Below healthy range.
                else if (resultBMI < HEALTHY_RANGE_MIN)
                {
                    canvas_main.Background = Brushes.Blue;
                    label_result.Content = String.Format("[BMI: {0:0.0}] You are below the healthy range!", resultBMI);
                }
                else//within healthy range.
                {
                    canvas_main.Background = Brushes.Green;
                    label_result.Content = String.Format("[BMI: {0:0.0}] You are within the healthy range!", resultBMI);
                }
            }
        }
    }
}
