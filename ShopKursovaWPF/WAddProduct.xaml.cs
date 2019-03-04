using ShopKursovaWPF.Models;
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
    /// Interaction logic for WAddProduct.xaml
    /// </summary>
    public partial class WAddProduct : Window
    {
        public WAddProduct()
        {
            InitializeComponent();
        }

        private void Click_addProduct(object sender, RoutedEventArgs e)
        {
            int price = 0;Int32.TryParse(txt_ProductPrice.Text,out price);
            int quantity = 0;Int32.TryParse(txt_ProductQuantity.Text, out quantity);
            Product product = new Product();
            product.Name = txt_ProductName.Text;
            product.Price = price;
            product.Quantity = quantity;
            Supplier f = new Supplier();
            product.supplier = f;
            using (ShopKurs shopKurs = new ShopKurs())
            {
                shopKurs.Products.Add(product);
              
            }
            this.Close();
        }
    }
}
