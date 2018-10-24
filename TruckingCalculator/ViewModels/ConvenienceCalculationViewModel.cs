using System;
namespace TruckingCalculator.ViewModels
{
	public class ConvenienceCalculationViewModel : BaseViewModel
    {
        private decimal originalPayment = 0m;
        private decimal finalPayment = 0m;
        private decimal percentageOfMoneyWitheld = 0m;

        public decimal OriginalPayment
        {
            get { return originalPayment; }
            set { SetProperty(ref originalPayment, value); }
        }

        public decimal FinalPayment
        {
            get { return finalPayment; }
            set { SetProperty(ref finalPayment, value); }
        }

        public decimal PercentageOfMoneyWitheld
        {
            get { return percentageOfMoneyWitheld; }
            set { SetProperty(ref percentageOfMoneyWitheld, value); }
        }
        public ConvenienceCalculationViewModel()
        {
        }
    }
}
