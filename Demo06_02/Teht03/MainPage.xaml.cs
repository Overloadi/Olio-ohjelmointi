﻿using System;
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

namespace Teht03
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private double ikkunanleveys;
        private double ikkunankorkeus;
        private double karmipuunleveys;
        private double ikkunanpa;
        private double lasinpa;
        private double karminpiiri;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void laskePA_click(object sender, RoutedEventArgs e)
        {
            ikkunanleveys = double.Parse(ikkunanLeveys.Text);
            ikkunankorkeus = double.Parse(ikkunanKorkeus.Text);
            karmipuunleveys = double.Parse(karmipuunLeveys.Text);
            ikkunanpa = ikkunanleveys * ikkunankorkeus;
            ikkunanPA.Text = ikkunanpa.ToString() + " cm^2";
            lasinpa = (ikkunanleveys - 2 * karmipuunleveys) * (ikkunankorkeus - 2 * karmipuunleveys);
            lasinPA.Text = lasinpa.ToString() + " cm^2";
            karminpiiri = ikkunanleveys * 2 + ikkunankorkeus * 2;
            karminPiiri.Text = karminpiiri.ToString() + " cm";
        }

        private void textBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
