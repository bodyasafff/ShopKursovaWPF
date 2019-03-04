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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Click_SignIn(object sender, RoutedEventArgs e)
        {
            if (txt_Login.Text == "admin" && txt_Password.Password == "admin")
            {
                WManager wManager = new WManager();
                wManager.Show();
                this.Close();
            }
        }
    }
}
