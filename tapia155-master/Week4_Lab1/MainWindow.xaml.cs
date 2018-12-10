/// Chapter No. Week4	Exercise No. Week4_Lab1
/// File Name:          Week4_Lab1.cs
/// @author:            Angel Tapia, shaun Goebel
/// Date:               September 10, 2018

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

namespace Week4_Lab1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String fullName, lastName, firstName, latinName;
            int space; //index of space

            fullName = Input.Text.Trim();
            
            space = fullName.IndexOf(" ");

            lastName = fullName.Substring(space);

            firstName = fullName.Substring(0, space);

            latinName = toPigLatin(firstName) + " " + toPigLatin(lastName);
            output.Content = latinName;

        }

        /// <summary>
        /// Converts text to Pig Lating
        /// </summary>
        /// <param name="fName">text to be to be converted</param>
        /// <returns>Pig Lating converted text</returns>
        string toPigLatin(string fName)
        {
            fName = fName.Trim().ToLower();
            string latinFname = fName.Substring(1, 1).ToUpper();
            latinFname += fName.Substring(2) + fName.Substring(0, 1) + "ay";
            return latinFname;
        }
    }
}
