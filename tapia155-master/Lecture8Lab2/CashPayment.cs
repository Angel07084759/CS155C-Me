/// Lecture8	        Exercise No. Lab2
/// File Name:          CashPayment.cs
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
    class CashPayment : Payment
    {
        
        public CashPayment(double amount) : base(amount) { }

        public override void PaymentDetails()
        {
            Console.WriteLine("Your CASH payment is {0:C}.", Amount);
        }


    }
}
