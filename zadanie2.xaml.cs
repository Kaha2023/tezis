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
    /// Логика взаимодействия для zadanie2.xaml
    /// </summary>
    public partial class zadanie2 : Window
    {
        public zadanie2()
        {
            InitializeComponent();
        }

        private void hi_Click(object sender, RoutedEventArgs e)
        {
            text_l.Content = "Привет";
            text_l.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 0));
        }

        private void bye_Click(object sender, RoutedEventArgs e)
        {
            text_l.Content = "До свидания";
            text_l.Foreground = new SolidColorBrush(Color.FromRgb(111, 111, 0));
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            zadanie3 Zadanie3 = new zadanie3();
            Zadanie3.Show();
            Close();
        }
    }
}
