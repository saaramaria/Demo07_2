using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace LotteryApp
{
    /// <summary>
    /// Lottery app
    /// @author Saara Virtanen
    /// @version 28.2.2016
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private int rowno = 1;

        public MainPage()
        {
            // draw UI from XAML-code
            this.InitializeComponent();
        }

        private void drawNumbers_Click(object sender, RoutedEventArgs e)
        {
            // create a new lottery-object
            Lottery lottery = new Lottery();
            
            // convert the text of drawCount to int
            string drawString = drawCount.Text;
            int draws = int.Parse(drawString);

            // print the randomly generated rows to numberBlock
            for (int i = 0; i < draws; i++)
            {
                numberBlock.Text += "Row " + rowno.ToString("00") + ":   " + lottery.generateNumbers() + "\n";
                rowno++;
            }
        }

        private void clearNumbers_Click(object sender, RoutedEventArgs e)
        {
            // clear numbers from numberBlock and set rownumber to 1
            numberBlock.Text = "";
            rowno = 1;
        }
    }
}
