/// Lecture8	        Exercise No. Lab2
/// File Name:          Lecture8Lab2.cs
/// @author:            Angel Tapia
/// Date:               October 22, 2018
/// Problem Statement:  
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8Lab2
{
    class Lecture8Lab2
    {
        static void Main(string[] args)
        {
            Payment payment = new Payment();
            payment.PaymentDetails();

            CashPayment cash1 = new CashPayment(35.99);
            cash1.PaymentDetails();

            CashPayment cash2 = new CashPayment(12.85);
            cash2.PaymentDetails();

            CreditCardPayment card = new CreditCardPayment(50.05, "Angel Tapia", 1234567890123456);
            card.PaymentDetails();

            CreditCardPayment c = new CreditCardPayment(9.85, "Daniel Vasquez",  0);
            c.PaymentDetails();

            Console.ReadLine();
        }
    }
}
