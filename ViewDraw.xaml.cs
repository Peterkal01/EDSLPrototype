﻿using System;
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

        private void buttonclickDiv1Draw(object sender, RoutedEventArgs e)
        {
            Div1Draw.Visibility = Visibility.Visible;
            DrawHeader.Visibility = Visibility.Visible;
        }

        

    }
}
