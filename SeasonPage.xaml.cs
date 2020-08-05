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

namespace EDSLPrototypeFinal
{
    /// <summary>
    /// Interaction logic for SeasonPage.xaml
    /// </summary>
    public partial class SeasonPage : Page
    {
        public SeasonPage()
        {
            InitializeComponent();
        }

        private void WatermarkText_GotFocus(object sender, RoutedEventArgs e)
        {
            watermarkText.Visibility = System.Windows.Visibility.Collapsed;
            userInput.Visibility = System.Windows.Visibility.Visible;
            userInput.Focus();
        }

        private void UserInput_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(userInput.Text))
            {
                userInput.Visibility = System.Windows.Visibility.Collapsed;
                watermarkText.Visibility = System.Windows.Visibility.Visible;
            }
        }
        
    }


}
