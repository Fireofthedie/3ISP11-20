using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
using Bober2.ClassHelper;
using Bober2.DB;
using Bober2;
using static Bober2.EF;

namespace Bober2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            LvProduct.ItemsSource = context.Product.ToList();
        }

        private void GoToCart_Click(object sender, RoutedEventArgs e)
        {
            CartWindow CartWindow = new CartWindow();
            CartWindow.Show();
            this.Close();
        }

        private void BtnAddCartService_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null)
            {
                return;
            }
            var product = button.DataContext as DB.Product; // получаем выбранную запись


            ProductCart.ProductCarts.Add(product);

            MessageBox.Show($"Товар {product.Title} добавлен в корзину!");
        }

    }
}
