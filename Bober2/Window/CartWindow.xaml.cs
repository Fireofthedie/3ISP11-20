using Bober2.DB;
using Bober2;
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
using System.Windows.Shapes;
using static Bober2.EF;

namespace Bober2
{
    /// <summary>
    /// Логика взаимодействия для CartWindow.xaml
    /// </summary>
    public partial class CartWindow : Window
    {

        public CartWindow()
        {
            InitializeComponent();
        }

        private void BtnGoToOrder_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Успешная покупка", "Успех!", MessageBoxButton.OK, MessageBoxImage.Asterisk);

        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Mainwindow = new MainWindow();
            Mainwindow.Show();
            this.Close();
        }
    }
}
