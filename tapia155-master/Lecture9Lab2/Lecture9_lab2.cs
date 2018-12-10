/// Lecture9	        Exercise No. Lab2
/// File Name:          Lecture9_lab2.cs
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
    class Lecture9_Lab2
    {
        //Tester method that searches for a keyword in a document.
        public static bool ContainsKeyword(Document docObject, string keyword)
        {
            if (docObject.ToString().IndexOf(keyword, 0) >= 0)
            {
                return true;
            }
            return false;
        }
        
        //Main tests two different type of Document(2 emails and 2 files)
        static void Main(string[] args)
        {
            string testText = "test";

            Email email1 = new Email("angelTapia@gmail.com", "kevinLewis@gmail.com", "lecture9Lab2Test1");
            Email email2 = new Email("tapiaAngel@gmail.com", "lewisKevin@gmail.com", "lecture9Lab2Test2");

            email1.SetText("This is a EMAIL that contains a keyword: " + testText );
            email2.SetText("This is a EMAIL that DOES NOT contains a keyword ");

            File file1 = new File(@"C:\home\file1");
            File file2 = new File(@"C:\home\file2");

            file1.SetText("This is a FILE that contains a keyword: " + testText);
            file2.SetText("This is a FILE that DOES NOT contains a keyword ");



            Console.WriteLine(email1);
            Console.WriteLine("contains \"" + testText + "\": " + ContainsKeyword(email1, testText) + "\n");

            Console.WriteLine(email2);
            Console.WriteLine("contains \"" + testText + "\": " + ContainsKeyword(email2, testText) + "\n");

            Console.WriteLine(file1);
            Console.WriteLine("contains \"" + testText + "\": " + ContainsKeyword(file1, testText) + "\n");

            Console.WriteLine(file2);
            Console.WriteLine("contains \"" + testText + "\": " + ContainsKeyword(file2, testText) + "\n");

            Console.ReadLine();
        }
    }
}
