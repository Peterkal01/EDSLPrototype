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
    /// Interaction logic for ViewDraw.xaml
    /// </summary>
    public partial class ViewDraw : Page
    {
        public ViewDraw()
        {
            InitializeComponent();
        }

        private void viewDraw(object sender, RoutedEventArgs e)
        {
            Main.Content = new ViewDraw();
        }

        private void buttonclickDraw(object sender, RoutedEventArgs e)
        {
           
            String fileName2 = "C:\\Users\\peter\\OneDrive - Swinburne University\\Diploma\\James\\Sem2\\EDSLPrototype\\Division1_Draw.pdf";
            System.Diagnostics.Process process2 = new System.Diagnostics.Process();
            process2.StartInfo.FileName = fileName2;
            process2.Start();
            process2.WaitForExit();

        }


        private void buttonClickLadder(object sender, RoutedEventArgs e)
        {
            String fileName2 = "C:\\Users\\peter\\OneDrive - Swinburne University\\Diploma\\James\\Sem2\\EDSLPrototype\\LadderExample.pdf";
            System.Diagnostics.Process process2 = new System.Diagnostics.Process();
            process2.StartInfo.FileName = fileName2;
            process2.Start();
            process2.WaitForExit();
        }
        private void buttonclickPrintReports(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Reports have been sent to your printer ");
        }

       

    }
}
