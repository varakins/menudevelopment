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

namespace NedoPaint
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NedoPaintsdf.EditingMode = InkCanvasEditingMode.None;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider slider = sender as Slider;
            var drawingAttributes = NedoPaintsdf.DefaultDrawingAttributes;
            drawingAttributes.Height = slider.Value * 2;
            drawingAttributes.Width = slider.Value * 2;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var drawingAttributes = NedoPaintsdf.DefaultDrawingAttributes;
            ComboBoxItem typeItem = (ComboBoxItem)Color.SelectedItem;
            string SelectedText = typeItem.Content.ToString();
            if (SelectedText == "Красный")
            {
                drawingAttributes.Color = Colors.Red;
            }
            else if(SelectedText == "Чёрный")
            {
                drawingAttributes.Color = Colors.Black;
            }
            else if(SelectedText == "Синий")
            {
                drawingAttributes.Color = Colors.Blue;
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            NedoPaintsdf.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            NedoPaintsdf.EditingMode = InkCanvasEditingMode.Select;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            NedoPaintsdf.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }
    }
}
