using System;
namespace TruckingCalculator.ViewModels
{
	public class ConvenienceCalculationViewModel : BaseViewModel
    {
        public decimal OriginalPayment
        {
            get;
            set;
        }

        public decimal FinalPayment
        {
            get;
            set;
        }

        public decimal PercentageOfMoneyWitheld
        {
            get;
            set;
        }
        public ConvenienceCalculationViewModel()
        {
        }
    }
}
