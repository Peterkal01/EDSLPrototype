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

        private void buttonclickCreate(object sender, RoutedEventArgs e)
        {
            SeasonDivId.Visibility = Visibility.Visible;
            SeasonDivIdUserInput.Visibility = Visibility.Visible;
            NoOfRounds.Visibility = Visibility.Visible;
            NoOfRoundsUserInput.Visibility = Visibility.Visible;
            StartDate.Visibility = Visibility.Visible;           
            buttonConfirm.Visibility = Visibility.Visible;
            enterDates.Visibility = Visibility.Visible;
            createDrawButton.Visibility = Visibility.Visible;
            saveDatesButton.Visibility = Visibility.Visible;
            saveSeasonButton.Visibility = Visibility.Visible;
        }

        /*private void buttonclickConfirm(object sender, RoutedEventArgs e)
        {
            DateList.Items.Add(enterDates.Text);
        }*/

        private void buttonclickRemoveDate(object sender, RoutedEventArgs e)
        {
            DateList.Items.Remove(DateList.SelectedItem);
        }

        private void buttonclickConfirm(object sender, RoutedEventArgs e)
        {
            DateList.Visibility = Visibility.Visible;
            removeDateButton.Visibility = Visibility.Visible;
            
        }
        private void buttonclickCreateDraw(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The draw has been created");
        }
        private void buttonclickSaveDates(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Dates saved");
        }
        private void buttonclickSaveSeason(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Season saved");
        }
    }



}
