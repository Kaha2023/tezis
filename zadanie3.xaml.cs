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
    /// Логика взаимодействия для zadanie3.xaml
    /// </summary>
    public partial class zadanie3 : Window
    {
        public zadanie3()
        {
            InitializeComponent();
        }

        private void but1_Click(object sender, RoutedEventArgs e)
        {
            text_l.Content = vvod1.Text;
        }

        private void but2_Click(object sender, RoutedEventArgs e)
        {
            text_l.Content = vvod2.Text;
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            zadanie4 Zadanie4 = new zadanie4();
            Zadanie4.Show();
            Close();
        }
    }
}
