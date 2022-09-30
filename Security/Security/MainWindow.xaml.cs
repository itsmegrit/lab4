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

namespace Security
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

        private void btnClick(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            txtCode.Password += btn.Content;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            btnClick(sender, e);
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            btnClick(sender, e);

        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            btnClick(sender, e);

        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            btnClick(sender, e);

        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            btnClick(sender, e);

        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            btnClick(sender, e);

        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            btnClick(sender, e);

        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            btnClick(sender, e);

        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            btnClick(sender, e);

        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            btnClick(sender, e);

        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            txtCode.Password ="";
        }

        private int ExistCode(string code)
        {
            int res = 0;
            if(code == "1645" || code == "1689")
            {
                return 1;
            }
            if (code == "8345")
            {
                return 2;
            }
            if (code == "9998" || code == "1006" || code == "1008")
            {
                res = 3;
            }
            return res;
        }

        private void btnHashtag_Click(object sender, RoutedEventArgs e)
        {
            String code = txtCode.Password.ToString();
            DateTime now = DateTime.Now;
            if (ExistCode(code)==1)
            {
                activityLog.Items.Add($"{now}   Technicians");
            } else if (ExistCode(code) == 2)
            {
                activityLog.Items.Add($"{now}  Custodians ");
            } else if (ExistCode(code) == 3)
            {
                activityLog.Items.Add($"{now}  Scientist");
            } else
            {
                activityLog.Items.Add($"{now}  Restricted Access ");
            }
            txtCode.Password = "";
        }
    }
}
