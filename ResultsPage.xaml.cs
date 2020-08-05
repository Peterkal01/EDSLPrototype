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
    /// Interaction logic for Results.xaml
    /// </summary>
    public partial class Results : Page
    {
        public Results()
        {
            InitializeComponent();
        }
        private void buttonclickViewResults(object sender, RoutedEventArgs e)
        {
            headerRound.Visibility = Visibility.Visible;
            homeTeam.Visibility = Visibility.Visible;
            awayTeam.Visibility = Visibility.Visible;
            score.Visibility = Visibility.Visible;
            game1.Visibility = Visibility.Visible;
            game2.Visibility = Visibility.Visible;
            game3.Visibility = Visibility.Visible;
            game4.Visibility = Visibility.Visible;
            game5.Visibility = Visibility.Visible;
            game6.Visibility = Visibility.Visible;
            game7.Visibility = Visibility.Visible;
            homeTeamList.Visibility = Visibility.Visible;
            awayTeamList.Visibility = Visibility.Visible;
            scoreList.Visibility = Visibility.Visible;
            updateResultsButton.Visibility = Visibility.Visible;
            updateLadderButton.Visibility = Visibility.Visible;
        }
    }
}
