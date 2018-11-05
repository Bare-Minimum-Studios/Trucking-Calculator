using System;
using System.Collections.Generic;
using TruckingCalculator.ViewModels;
using Xamarin.Forms;

namespace TruckingCalculator.Views
{
    public partial class ConvenienceCalculationPage : ContentPage
    {
        private ConvenienceCalculationViewModel viewModel = null;
        public ConvenienceCalculationPage()
        {
            InitializeComponent();
            viewModel = new ConvenienceCalculationViewModel
            {
                OriginalPayment = 0.0m,
                FinalPayment = 0.0m,
                PercentageOfMoneyWitheld = 0.0m
            };
            BindingContext = this.viewModel;
        }

        void OriginalFocus(object sender, bool IsFocused)
        {
            
            if (IsFocused)
            {
                _originalPayment.Text = "";
            }
        }

        void FinalFocus(object sender, bool IsFocused)
        {

            if (IsFocused)
            {
                _finalPayment.Text = "";
            }
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (viewModel.OriginalPayment != 0)
            {
                var percentageOfPayment = viewModel.FinalPayment /
                                         viewModel.OriginalPayment;

                this.viewModel.PercentageOfMoneyWitheld =
                    (1m - percentageOfPayment) * 100m;
            }
            else
            {
                DisplayAlert("Original payment should be greater than zero", "Original Payment cannot be zero.", "OK");
            }
        }
    }
}
