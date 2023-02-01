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

namespace Urvancev
{
    /// <summary>
    /// Логика взаимодействия для zadanie4.xaml
    /// </summary>
    public partial class zadanie4 : Window
    {
        public zadanie4()
        {
            InitializeComponent();
        }

        private void kn1_Click(object sender, RoutedEventArgs e)
        {
            kn1.Content = text_l.Text;
        }

        private void kn2_Click(object sender, RoutedEventArgs e)
        {
            kn2.Content = text_l.Text;
        }
    }
}
