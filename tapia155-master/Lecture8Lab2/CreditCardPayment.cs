/// Lecture8	        Exercise No. Lab2
/// File Name:          CreditCardPayment.cs
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
    class CreditCardPayment : Payment
    {
        ulong cardNum;
        String cardName;


        public CreditCardPayment(double amount, String cardName, ulong cardNum) : base(amount)
        {
            CardNum = cardNum;
            CardName =cardName;
            
        }
        public string CardName
        {
            get { return cardName; }
            set { cardName = value; }
        }

        public ulong CardNum
        {
            get { return cardNum; }
            set { cardNum = value; }
        }

        public override void PaymentDetails()
        {
            Console.WriteLine("{0}, your CREDIT_CARD({1:D16}) payment is {2:C}.", CardName,CardNum, Amount);
        }
    }
}
