/// Lecture: 12	        Exercise No. Homework12
/// File Name:          Homework12.cs
/// @author:            Angel Tapia
/// Date:               December 3, 2018
/// Problem Statement:  This program uses a delegate to calculate 
///                     the area of a square, circle or triangle.
///                     
/// Algorithm:
/// Create a delegate double MyDelegate(double size);
/// Create a delegate type calArea;
/// Create a double calcSquareArea(double size)
///     return size * size;
/// Create a double calcTriangleArea(double size)
///     return (size * size) / 2.0;
/// Create a double calcCircleArea(double size)
///     return Math.PI * (size * size);
/// Create a button_Selected method(Button a, Button b, Button c):
///     set a.BorderBrush = Brushes.DarkOliveGreen;
///     b and c = default colors
/// Create a square_Click method:
///     set calArea = calcSquareArea;
///     call button_Selected(square, triangle, circle);
/// Create a triangle_Click method:
///     set calArea = calcTriangleArea;
///     call button_Selected(triangle, square, circle);
/// Create a circle_Click method:
///     set calArea = calcCircleArea;
///     call button_Selected(circle, triangle, square);
/// Create a calculate_Click method:
///     if parsed input is a numerical value:
///         set output = calArea(pared_input);
///     else set output = err message;
/// Call triangle_Click(triangle, null); the windows constructor. 
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

namespace Homework12//to calculate the area of a square, circle or triangle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private delegate double MyDelegate(double size);
        private MyDelegate calArea;//Calculates the area of a square triangle, or circle

        public MainWindow()
        {
            InitializeComponent();
            triangle_Click(triangle, null);
        }

        private double calcSquareArea(double size)
        {
            return size * size;
        }

        private double calcTriangleArea(double size)
        {
            return (size * size) / 2.0;
        }

        private double calcCircleArea(double size)
        {
            return Math.PI * (size * size);
        }

        private void button_Selected(Button a, Button b, Button c)
        {
            a.BorderBrush = Brushes.DarkOliveGreen;
            b.BorderBrush = new Button().BorderBrush;
            c.BorderBrush = new Button().BorderBrush;
        }
        
        private void square_Click(object sender, RoutedEventArgs e)
        {
            calArea = calcSquareArea;
            button_Selected(square, triangle, circle);
        }

        private void triangle_Click(object sender, RoutedEventArgs e)
        {
            calArea = calcTriangleArea;
            button_Selected(triangle, square, circle);
        }

        private void circle_Click(object sender, RoutedEventArgs e)
        {
            calArea = calcCircleArea;
            button_Selected(circle, triangle, square);
        }

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(input.Text.Trim(), out double temp))
            {
                output.Content = "Area = " + calArea(temp);
            }
            else
            {
                input.Text = "";
                output.Content = "Please enter a numerical value!!";
            }
        }
    }
}
