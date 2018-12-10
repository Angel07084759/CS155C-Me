/// Lecture8	        Exercise No. Lab2
/// File Name:          Payment.cs
/// @author:            Angel Tapia
/// Date:               October 22, 2018
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8Lab2
{
    class Payment
    {
        private double amount;//Payment amount

        //Default constructor
        public Payment()
        {
            Amount = 0;
        }

        //Full constructor
        public Payment(double amount) : this()
        {
            Amount = amount;
        }

        //Property for amount
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        //Payment Details
        public virtual void PaymentDetails()
        {
            Console.WriteLine("Your payment is {0:C}.", Amount);
        }

    }
}
