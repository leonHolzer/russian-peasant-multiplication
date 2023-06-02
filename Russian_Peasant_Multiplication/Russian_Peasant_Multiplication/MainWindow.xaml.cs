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
using Russian_Peasant_Multiplication_Logic;

namespace Russian_Peasant_Multiplication
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

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            txbResult.Text = RussianPeasantMultiplication.Multiply(27, 82).ToString();
        }
    }
}
