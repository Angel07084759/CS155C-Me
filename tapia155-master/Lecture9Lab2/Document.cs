/// Lecture9	        Exercise No. Lab2
/// File Name:          Document.cs
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
    //Base class
    class Document
    {
        //Instance variable.
        private string text;

        //Default constructor.
        public Document()
        {
            text = "";
        }

        //Full constructor.
        public Document(string text)
        {
            SetText(text);
        }

        //text Setter.
        public void SetText(string text)
        {
            this.text = text;
        }
        //Returns the current value of text.
        public override string ToString()
        {
            return text;
        }
    }
}
