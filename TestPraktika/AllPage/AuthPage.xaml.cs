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

namespace TestPraktika.AllPage
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void AgentButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (App.testPraktika.Client.FirstOrDefault(c => c.password == tbPassword.Password && c.login == tbLogin.Text).id != 0)
                {
                    NavigationService.Navigate(new MainPage());
                }
            }
            catch
            {
                MessageBox.Show("Оштбка");
            }
            

        }
    }
}
