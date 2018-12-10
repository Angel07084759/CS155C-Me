/// Lecture9	        Exercise No. Lab2
/// File Name:          File.cs
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
    class File : Document
    {
        //Instance variable
        string path;

        //Default constructor: 
        //uses the base constructor initialize text and initializes path = "".
        public File() : base()
        {
            Path = "";
        }

        //Constructor that uses the base constructor initialize text and path to the given value.
        public File(string path) : base()
        {
            Path = path;
        }

        //Property for path.
        public string Path { get { return path; } set { path = value; } }

        //Builds and return a string representation of an file: include path and textual content.
        public override string ToString()
        {
            return "PATH: " + path + "  TEXT: " + base.ToString();
        }
    }
}
