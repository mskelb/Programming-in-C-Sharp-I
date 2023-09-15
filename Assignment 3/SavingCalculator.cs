using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{

    class SavingCalculator
    {
        private int numOfMonths;
        private int monthlyDeposit;
        private int period;
        private int amountPaid;
        private double interestRate;
        private double feesRate;
        private double fees;

    
    #region Getters and Setters
        public int GetMonthlyDeposit()
        {
            return monthlyDeposit;
        }
        public double GetInterestRate() 
        {
            return interestRate;
        }
        public double GetFeesRate()
        {
            return feesRate;
        }
        public double GetFees()
        {
            return fees;
        }
        public double GetNumOfMonth()
        {
            return numOfMonths;
        }
        public int GetPeriod()
        {
            return period;
        }
        public double GetAmountPaid() 
        {
            return amountPaid;
        }
        public void SetInterestRate(double value )
        {
            interestRate = value;
        }
        public void SetFeesRate(double value)
        {
            feesRate = value;
        }
        public void SetFees(double value)
        {
            fees = value;
        }
        public void SetMonthlyDeposit(int value)
        {
            monthlyDeposit = value;
        }
        public void SetNumOfMonth(int value)
        {
            numOfMonths = value;
        }
        public void SetPeriod(int value)
        {
            period = value;
        }
        #endregion
        public double CalculateSaving()
        {
            double balance = 0.0;
            double interestEarned = 0.0;
            int paid = 0;
            double temp = 0.0;
            for (int i = 0; i < numOfMonths; i++)
            {
                paid += monthlyDeposit;
                interestEarned = interestRate * balance;
                balance += interestEarned + monthlyDeposit;
                temp += (balance * feesRate);
            }
            this.fees = temp;
            this.amountPaid = paid;
            return (balance - temp);
        }
    }
}
