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

namespace Ejercicio5
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

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Resultado.FontWeight = FontWeights.UltraBold;
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            Resultado.FontWeight = FontWeights.Black;
        }
        private void CheckBox_Unchecked_1(object sender, RoutedEventArgs e)
        {
            Resultado.FontWeight = FontWeights.Normal;
        }
        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Resultado.FontWeight = FontWeights.Normal;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Resultado.Foreground = Brushes.Blue;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            Resultado.Foreground = Brushes.Red;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            Resultado.Foreground = Brushes.Green;
        }

        private void Input_TextChanged(object sender, TextChangedEventArgs e)
        {
            Resultado.Text = Input.Text;
        }
    }
}
