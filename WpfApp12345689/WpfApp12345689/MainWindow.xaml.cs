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

namespace WpfApp12345689
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OKNO.Background = Brushes.White;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OKNO.Background = Brushes.White;
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            OKNO.Background = Brushes.Blue;
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            OKNO.Background = Brushes.Blue;
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            OKNO.Background = Brushes.Red;
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            OKNO.Background = Brushes.Red;
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Хороший разработчик\nберёт не дорого\n Телефон 8-800-555-35-35", "Разработчик Варакин Сергей", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Хороший разработчик\nберёт не дорого\n Телефон 8-800-555-35-35", "Разработчик Варакин Сергей", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            sostoanie.Text = "Белый фон";
        }

        private void Button_MouseEnter_1(object sender, MouseEventArgs e)
        {
            sostoanie.Text = "Синий фон";
        }

        private void Button_MouseEnter_2(object sender, MouseEventArgs e)
        {
            sostoanie.Text = "Красный фон";
        }

        private void Button_MouseEnter_3(object sender, MouseEventArgs e)
        {
            sostoanie.Text = "Нажав на данную кнопку ты узнаешь инфу о разработчике";
        }

        private void Button_MouseEnter_4(object sender, MouseEventArgs e)
        {
            sostoanie.Text = "Закроет окно нашего приложения";
        }
    }
}
