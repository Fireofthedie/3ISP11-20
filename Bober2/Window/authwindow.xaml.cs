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
using System.Windows.Shapes;
using static Bober2.EF;

namespace Bober2
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class authwindow : Window
    {
        public authwindow()
        {
            InitializeComponent();
        }

        private void BtnAuth_Click(object sender, RoutedEventArgs e)
        {
            var person = context.Client.Where(i => i.Login == TbLogin.Text && i.Password == PbPassword.Password).FirstOrDefault();
            if (person != null)
            {
                MainWindow Mainwindow = new MainWindow();
                Mainwindow.Show();
                this.Close();
            }

            else
            {
                MessageBox.Show("Нет такого человека");
            }

        }
    }
}
