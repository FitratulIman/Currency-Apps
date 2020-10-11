﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Currancy_AppS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CurrencyControler currency;
        public MainWindow()
        {
            currency = new CurrencyControler();
            InitializeComponent();
        }

        private void Button_Hitung_Click(object sender, RoutedEventArgs e)
        {
            var nominalInput = InputTextBox.Text;
            var result = "Invalid";
            if (currency.isAllowed(nominalInput))
            {
                result = currency.usdToIdr(nominalInput);
            }
            resultLabel.Content = result;

        }
    }
}
