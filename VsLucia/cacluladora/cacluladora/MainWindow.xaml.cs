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

namespace cacluladora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)rbSuma.IsChecked)
                suma();
            else
                resta();
        }
        public void suma()
        {
            txRes.Text = "" + (Convert.ToDouble(txNum1.Text) + Convert.ToDouble(txNum2.Text));

        }

        public void resta()
        {
            txRes.Text = "" + (Convert.ToDouble(txNum1.Text) - Convert.ToDouble(txNum2.Text));

        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LbNum2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
