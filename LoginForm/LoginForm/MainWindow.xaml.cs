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

namespace LoginForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if (Properties.Settings.Default.username != String.Empty)
            {
                txtUsername.Text = Properties.Settings.Default.username;
                txtPassword.Password = Properties.Settings.Default.password;
                cbSave.IsChecked = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Password.ToString() == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            if (txtUsername.Text != "admin" || txtPassword.Password.ToString() != "admin")
            {
                MessageBox.Show("Login Fail!");
                return;
            }
            if (txtUsername.Text == "admin" && txtPassword.Password.ToString() == "admin")
            {
                if (cbSave.IsChecked==true)
                {
                    Properties.Settings.Default.username = txtUsername.Text;
                    Properties.Settings.Default.password = txtPassword.Password.ToString();
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.username = null;
                    Properties.Settings.Default.password = null;
                    Properties.Settings.Default.Save();
                }
                MessageBox.Show("Login Successful");
                return;
            }
        }
    }
}
