/// Chapter No. Week5	Exercise No. Week5_Lab2
/// File Name:          Week5_Lab2.cs
/// @author:            Angel Tapia, shaun Goebel
/// Date:               September 17, 2018
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

namespace Week5_Lab2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        //Constants
        public const int FINE = 60;
        public const int PENALTY = 250;
        public const int ADDITIONAL = 7;
        public const int OVER_TWENTY_FIVE = 25;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int speedLimit = 0;
            int clockedSpeed = 0;
            int fineAmount = 0;

            //speedLimit = Convert.ToInt32(Console.ReadLine().Trim());
            speedLimit = Convert.ToInt32(speedlimit.Text);
            clockedSpeed = Convert.ToInt32(clockedspeed.Text);
            //clockedSpeed = Convert.ToInt32(Console.ReadLine().Trim());

            //Legal Speed
            if (clockedSpeed <= speedLimit)
            {
                //Needs Code
                fineamount.Content = "Legal Speed";
                canvas.Background = Brushes.Green;
            }
            else//Penalty for ecceding speed limit
            {

                int temp = ((clockedSpeed - speedLimit) / OVER_TWENTY_FIVE);


                if (temp > 0)//penalty for ecceding over 25 mph
                {
                    fineAmount += (PENALTY * temp);
                    canvas.Background = Brushes.Red;
                }
                else
                {
                    canvas.Background = Brushes.Yellow;
                }
                //Penealty for each mph over speed limit
                fineAmount += (clockedSpeed - speedLimit) * ADDITIONAL;
                fineAmount += FINE;

                fineamount.Content = "" + fineAmount;
            }
        }
    }
}
