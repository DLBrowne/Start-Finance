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
using InstaRichie.ViewModels;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace InstaRichie.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DashBoardPage : Page
    {
        public DashBoardPage()
        {
            this.InitializeComponent();
            Calculations nnn = new Calculations();
            AccountTotal.Text = "Accounts: " + nnn.AccountTotal().ToString();
            Assets.Text = nnn.AssetCalculation().ToString();
            Debts.Text = nnn.CreditRatio().ToString();
            string dmo = nnn.DebtCalculation().ToString();
            FullTotal.Text = nnn.FullValuation().ToString();
            string dmdm = nnn.MonthlyStatus().ToString();
            string fgf = nnn.PercentageScore().ToString();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Calculations nnn = new Calculations();
            AccountTotal.Text = "Accounts: " + nnn.AccountTotal().ToString();
            Assets.Text = nnn.AssetCalculation().ToString();
            Debts.Text = nnn.CreditRatio().ToString();
            string dmo = nnn.DebtCalculation().ToString();
            FullTotal.Text = nnn.FullValuation().ToString();
            string dmdm = nnn.MonthlyStatus().ToString();
            string fgf = nnn.PercentageScore().ToString();
        }
    }
}
