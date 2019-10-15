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

using WpfLibNice;

namespace WpfApp
{

    // This Source Code Form is subject to the terms of the MIT License.
    // Copyright(C) Jan Luk. All Rights Reserved 2019.

    // Nice WPF windows with dynamic themes changing.
    // In this project, I wrote classes to create nice WPF windows in .NET6 (extension to .NET Core).
    // Standard windows in WIN10 are poor, primitive, for example, sometimes the title bar and the
    // window frame do not stand out from the background, an impression of chaos appears on the screen.
    // My windows have 3D elements, double frames, 3D buttons and other graphic elements.
    // Many 'Styles' and dynamic events are defined in WPF. This makes it possible to reload the Light
    // and Dark styles on the fly.
    // In future versions I will try to provide a mechanism for adding more user Themes.

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region - Buttons -------------------------------

        /// <summary>
        /// Simple action 1
        /// </summary>
        private void butt1_Click(object sender, RoutedEventArgs e)
        {
            TxtEd.Text = "Action1";
        }

        /// <summary>
        /// Simple action 2
        /// </summary>
        private void butt2_Click(object sender, RoutedEventArgs e)
        {
            TxtEd.Text = "Action two";
        }

        /// <summary>
        /// Action of change for the next Themes
        /// </summary>
        private void butt5Change_Click(object sender, RoutedEventArgs e)
        {
            CChangeTheme cChangeTheme = new CChangeTheme();
            cChangeTheme.ThemeChangeNextAll();
        }

        #endregion ---------------------------
    }
}
