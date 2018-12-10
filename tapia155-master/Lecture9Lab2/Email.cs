/// Lecture9	        Exercise No. Lab2
/// File Name:          Email.cs
/// @author:            Angel Tapia
/// Date:               October 29, 2018
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9Lab2
{
    //Derived class of Document
    class Email : Document
    {
        //Instance variables
        private string sender;//sender email address.
        private string recipient;//recipient email address.
        private string title;//title of the email.

        //Default constructor: 
        //uses the base constructor initialize text and initializes
        //sender, recipient, and title to "".
        public Email() : base()
        {
            Sender = "";
            Recipient = "";
            Title = "";
        }

        //Constructor that uses the base constructor initialize text and initializes
        //sender, recipient, and title with the given values.
        public Email(string sender, string recipient, string title) : this()
        {
            Sender = sender;
            Recipient = recipient;
            Title = title;
        }

        //Property for sender.
        public string Sender { get { return sender; } set { sender = value; } }

        //Property for recipient.
        public string Recipient { get { return recipient; } set { recipient = value; } }

        //Property for title.
        public string Title { get { return title; } set { title = value; } }

        //Builds and return a string that contains all of the fields values.
        public override string ToString()
        {
            return String.Format("SENDER: {0, -25} RECIPIENT: {1, -25} TITLE: {2, -25}\n",
                   sender, recipient, title) + "BODY: " + base.ToString() ;
        }
    }
}
