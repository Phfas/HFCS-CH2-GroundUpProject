using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HFCS_CH2_GroundUpProject
{
    public partial class MainWindow
    {
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // this is a comment
            string name = "Quentin";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;
            myLabel.Text = "name is " + name
                + "\nx is " + x
                + "\nd is " + d;
        }
    }
}
