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

namespace Teht01
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private int draws;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            int randnumb;
            List<string> rows = new List<string>();
            string temp;
            string temp2;
            draws = int.Parse(drawsTextBox.Text);
            List<int> randomNumbers = new List<int>();
            for (int i = 1; i <= draws;i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    randnumb = rand.Next(1, 39 + 1);
                    if (randomNumbers.Contains(randnumb))
                    {
                        j--;
                        continue;
                    }
                    randomNumbers.Add(randnumb);
                   
                }
                temp = "Row " + i.ToString("00") + ": ";
                temp2 = temp + string.Join(" ", randomNumbers.ToArray()) + "\n";
                rows.Add(temp2);
                randomNumbers.Clear();
            }
            randomNumbersTextBlock.Text = String.Join(String.Empty, rows.ToArray());
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            randomNumbersTextBlock.Text = "";
        }
    }
}
