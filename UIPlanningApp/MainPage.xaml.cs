using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UIPlanningApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            // piirretään UI XAML-koodista
            this.InitializeComponent();
            // vaihdetaan ikkunan käynnistysmoodia
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            // ikkunan koko
            ApplicationView.PreferredLaunchViewSize = new Size(800, 600);
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Name: " + nameTextBox.Text);
            Debug.WriteLine("Email: " + emailTextBox.Text);
            // password, kotitehtävä
            if ((bool)userRadioButton.IsChecked) Debug.WriteLine("Normal user");
            if ((bool)adminRadioButton.IsChecked) Debug.WriteLine("Admin");
        }
    }
}
