/// Chapter No. MidtermExtraCredit
/// File Name:          MidtermExtraCredit.cs
/// @author:            Angel Tapia
/// Date:               October 8, 2018
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

namespace MidtermExtraCredit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Kinematics kinematics;
        public MainWindow()
        {
            kinematics = new Kinematics();
            InitializeComponent();
        }     

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void solve_Click(object sender, RoutedEventArgs e)
        {
            double temp = 0;
            Double.TryParse(dt.Text.Trim(), out temp);
            kinematics.SetDeltaT(temp);

            Double.TryParse(dv.Text.Trim(), out temp);
            kinematics.SetDeltaV(temp);

            Double.TryParse(dp.Text.Trim(), out temp);
            kinematics.SetDeltaP(temp);

            Double.TryParse(ti.Text.Trim(), out temp);
            kinematics.SetTInitial(temp);

            Double.TryParse(tf.Text.Trim(), out temp);
            kinematics.SetTFinal(temp);

            Double.TryParse(vi.Text.Trim(), out temp);
            kinematics.SetVInitial(temp);

            Double.TryParse(vf.Text.Trim(), out temp);
            kinematics.SetVFinal(temp);

            Double.TryParse(pi.Text.Trim(), out temp);
            kinematics.SetPInitial(temp);

            Double.TryParse(pf.Text.Trim(), out temp);
            kinematics.SetPFinal(temp);

            Double.TryParse(a.Text.Trim(), out temp);
            kinematics.SetAcceleration(temp);


            kinematics.SolveDeltaT();
            kinematics.SolveDeltaV();
            kinematics.SolveDeltaP();

            kinematics.SolveVInitial();
            kinematics.SolveVFinal();





            dt.Text = kinematics.GetDeltaT().ToString();
            dv.Text = kinematics.GetDeltaV().ToString();
            dp.Text = kinematics.GetDeltaP().ToString();
            ti.Text = kinematics.GetTInitial().ToString();
            tf.Text = kinematics.GetTFinal().ToString();
            vi.Text = kinematics.GetVInitial().ToString();
            vf.Text = kinematics.GetVFinal().ToString();
            pi.Text = kinematics.GetPInitial().ToString();
            pf.Text = kinematics.GetPFinal().ToString();
            a.Text = kinematics.GetAcceleration().ToString();
        }
    }
}
