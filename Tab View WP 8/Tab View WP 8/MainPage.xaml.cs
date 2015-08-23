using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Tab_View_WP_8.Resources;

namespace Tab_View_WP_8
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void TabButtonClick(object sender, GestureEventArgs e)
        {
            StackPanel panel = sender as StackPanel;
            if (panel != null && panel.Tag != null)
            {
                try
                {
                    this.HomePagePivot.SelectedIndex = Int16.Parse(panel.Tag.ToString());
                }
                catch (FormatException) { }
            }
        }
    }
}