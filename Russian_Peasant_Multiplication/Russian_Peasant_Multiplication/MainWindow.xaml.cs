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
        string _multiplicandInfo = "multiplicand";
        string _multiplierInfo = "multiplier";

        public MainWindow()
        {
            InitializeComponent();
            txbMultiplicand_LostFocus(new (), new RoutedEventArgs());
            txbMultiplier_LostFocus(new (), new RoutedEventArgs());
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((bool)rdbEfficencyMode.IsChecked)
                {
                    txbResult.Text = RussianPeasantMultiplication.Multiply(Convert.ToInt32(txbMultiplicand.Text), Convert.ToInt32(txbMultiplier.Text)).ToString();
                }

                else if ((bool)rdbHighNumberMode.IsChecked)
                {
                    txbResult.Text = RussianPeasantMultiplication.Multiply((long)Convert.ToInt32(txbMultiplicand.Text), (long)Convert.ToInt32(txbMultiplier.Text)).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        #region InputInfoLogic
        private void txbMultiplicand_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txbMultiplicand.Text == _multiplicandInfo)
            {
                txbMultiplicand.Text = "";
            }
        }

        private void txbMultiplicand_LostFocus(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txbMultiplicand.Text))
            {
                txbMultiplicand.Text = _multiplicandInfo;
            }
        }

        private void txbMultiplier_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txbMultiplier.Text == _multiplierInfo)
            {
                txbMultiplier.Text = "";
            }
        }

        private void txbMultiplier_LostFocus(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txbMultiplier.Text))
            {
                txbMultiplier.Text = _multiplierInfo;
            }
        }
        #endregion
    }
}
