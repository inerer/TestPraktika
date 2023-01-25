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
    /// Логика взаимодействия для EditAddPage.xaml
    /// </summary>
    public partial class EditAddPage : Page
    {
        
        
        Product _product;
        public EditAddPage()
        {
            InitializeComponent();
            
            _product = new Product();    
        }
        public EditAddPage( Product product)
        {
            InitializeComponent();
            _product = product;

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = _product;

        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if ( _product.id == 0)
            {
         
                App.testPraktika.Product.Add(_product);
               
            }
            App.testPraktika.SaveChanges();
            NavigationService.GoBack();
        }
    }
}
