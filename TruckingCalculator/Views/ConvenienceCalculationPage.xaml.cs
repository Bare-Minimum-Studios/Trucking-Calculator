using System;
using System.Collections.Generic;
using TruckingCalculator.ViewModels;
using Xamarin.Forms;

namespace TruckingCalculator.Views
{
    public partial class ConvenienceCalculationPage : ContentPage
    {
        public ConvenienceCalculationViewModel ViewModel
        {
            get;
            set;
        }
        public ConvenienceCalculationPage()
        {
            InitializeComponent();
            ViewModel = new ConvenienceCalculationViewModel
            {
                OriginalPayment = 0.0m,
                FinalPayment = 0.0m,
                PercentageOfMoneyWitheld = 0.0m
            };
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            ViewModel.PercentageOfMoneyWitheld = 75.25m;
        }
    }
}
