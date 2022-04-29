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

namespace Demo
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {

            InitializeComponent();   
            DataContext = this;

        }

        private void search_GotFocus(object sender, RoutedEventArgs e)
        {
            if (search.Text == "Введите для поиска")
            {
                search.Text = "";
            }
        }

        private void search_LostFocus(object sender, RoutedEventArgs e)
        {
            if (search.Text == "")
            {
                search.Text = "Введите для поиска";
            }
        }
    }
}
