using ShopKursovaWPF;
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

namespace ShopKursovaWPF
{
    /// <summary>
    /// Interaction logic for WManager.xaml
    /// </summary>
    public partial class WManager : Window
    {
        public WManager()
        {
            InitializeComponent();
        }

        private void Click_Add_Product(object sender, RoutedEventArgs e)
        {
            WAddProduct wAddProduct = new WAddProduct();
            wAddProduct.Show();
        }

        private void Click_Add_Delivery(object sender, RoutedEventArgs e)
        {
            WAddDelivery wAddDelivery = new WAddDelivery();
            wAddDelivery.Show();
        }

        private void Click_Add_Sale(object sender, RoutedEventArgs e)
        {

        }

        private void Click_Add_Supplire(object sender, RoutedEventArgs e)
        {

        }
    }
}
