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
using TestPraktika.Enteties;

namespace TestPraktika.AllPage
{
    /// <summary>
    /// Логика взаимодействия для OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Page
    {
        Product selectProduct;
        public OrderPage()
        {
            InitializeComponent();
        }

        private void OrderDataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            OrderDataGrid.ItemsSource = App.testPraktika.Product.ToList();
        }

        private void OrderDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectProduct = (Product)OrderDataGrid.SelectedItem;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (selectProduct == null)
            {
                MessageBox.Show("Выберите агента!", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (MessageBox.Show("Вы действительно хотите удалить информацию?", "Сообщение", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    App.testPraktika.Product.Remove(selectProduct);
                    App.testPraktika.SaveChanges();
                    OrderDataGrid_Loaded(null, null);
                }
            }

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditAddPage());
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (selectProduct == null)
            {
                MessageBox.Show("Выберите агента!", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                NavigationService.Navigate(new EditAddPage(selectProduct));
            }

        }
    }
}
