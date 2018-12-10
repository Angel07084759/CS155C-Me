/// Lecture: 11	        Exercise No. Homework11
/// File Name:          Homework11.cs
/// @author:            Angel Tapia
/// Date:               November 25, 2018
/// Problem Statement:  This is a tester program for a class Student
///                     that implements the IComparable interface.
///                     
/// Algorithm:
/// 1) Create a class Student that implement the IComparable interface
///     Create instance variable for:
///         string firstName, lastName; int score;
///     Create a default constructor that initializes
///         firstName = "" , lastName = ""  ; score = 0;
///     Create a full constructor that initializes 
///         firstName, lastName, score with the given values.
///     Create Getters and Setters.
///     Implement the CompareTo method:
///         Compares this objects score with the given object's score for sorting order.
///         Returns < 0 if this.score < obj.score; 0 if this.score == obj.score; else return > 0 .
///         throws InvalidCastException if the passed obj is not an instance of the Student class.
///     Override ToString():
///         Builds and returns a string representation of a student: first name, last name, and score
///     Override Equals():
///         Compares this students with another student.
///         Returns true if both score, firstName, and lastName are equivalent; false otherwise.
/// 2) Create a StudentStats class that reads student data from a file:
///     Create a private array of type char that store the delimiter for the file to be read.
///     Create a private list to store temp data from the file.
///     Create a full constructor that reads student data; populate and sort a student list:
///         Call ReadStudentFile(fileNameIn) to initialize the list of student.
///         Call DisplayStudentList() to display the original file list.
///         Call the sort method on the list object to sort the current list of student.
///     Create a method ReadStudentFile(string fileName) that reads a student data to populate the list of student:
///         Open the file stream with the using statement:
///             Read line by line and use the privet delimiter to break each data field into an array.
///             Use Int32.Parse to parse the student score.
///             create a student object with the parsed data and add it to the student list.
///     Create a method GetAverageScore() that return the average score in the student list:
///         Create a local variable double total and double count variable.
///         Add up all of student score in the student list.
///         Increment count for each student in the list.
///         if count == 0 return -1 as error signal; else return total / count;
///      Create a method GetMedianScore() that return the median score in the student list:
///         If the student list is empty return -1 as an error signal;
///         Else if student list contains one element or an odd number of elements:
///             Create a local variable int index = (studentList.Count / 2) 
///             to get the element in the middle of the list.
///                 return studentList[index].GetScore();
///         Else return the sum of two elements in the middle  divided it by 2.
///     Create a method WriteStudentStats(string fileName) that writes the 
///     average and median scores in the given file:
///         Open the file stream with the using statement:
///             Call the GetAverageScore method and store the result in a local variable, average.
///             Call the GetMedianScore method and store the result in a local variable, median.
///             Display average and median.
///             write average an d median in the given file.
///     Create a DisplayStudentList() that display the content in the student list:
///         Use a for each to display each element in the student list.
/// 3) Create a tester class and implement Main:
///     Manually create a file that contains student info as: first name , last name, and score.
///     Create local variables: 
///         string fileIn = "studentinfo.txt;
///         string fileOut = "studentstats.txt";
///         StudentStats studentStats = new StudentStats(fileIn);
///         Display unsorted array.
///         Call the method DisplayStudentList to Display the sorted array.
///         Call the method WriteStudentStats to write the average and 
///         median score to the given file.
///         pause the screen.
///             



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    class Homework11
    {
        static void Main(string[] args)
        {
            //File names
            string fileIn = "studentinfo.txt";
            string fileOut = "studentstats.txt";

            Console.WriteLine("========= Reading Student List ===========");
            StudentStats studentStats = new StudentStats(fileIn);

            Console.WriteLine("\n========= Sorted Student List ===========");
            studentStats.DisplayStudentList();

            Console.WriteLine("\n========= Writing Student Average and Median score ===========");
            studentStats.WriteStudentStats(fileOut);

            Console.ReadLine();
        }
    }
}
