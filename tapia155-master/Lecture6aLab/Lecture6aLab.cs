/// Chapter No. Week8	Exercise No. Lecture6aLab
/// File Name:          StudentRecord.cs
/// @author:            Angel Tapia
/// Date:               October 8, 2018
/// Problem Statement:  This program 
/// Algorithm:
/// 1) Create a class StudentRecord that stores data of a student grade:
///     -Create Constant for:
///         int QUIZ_MAX = 10; double QUIZZES = 0.25, MIDTERM = 0.35, FINAL = 0.40;
///     -Create instance variable for: int[] quiz; int midterm; int final;
///     -Create a default constructor that initializes quiz: quiz = new int[3];
///     -Create a full constructor that initializes all of the instance variables.
///         Call Setters: SetQuiz: 0,1,2; SetMidterm; SetFinal.
///     -Create a method SetQuiz(int quizNumber, int score):
///         Returns false if quiz number is out of bound in the quiz array; 
///         else set the score for the given quiz number and return true.
///     -Create a method SetMidterm(int score) that sets a score for midTerm.
///     -Create a method SetFinal(int score) that sets a score for final.
///     -Create a method GetLtterGrade() that returns a string representation of
///      the letter grade bases on the overall grade: F < 60 <= D < 70 <= C < 80 <= B < 90 <= A
///     -Create a method GetOverallGrade() that calculates the overall grade:
///         Add up all of the quizzes midterm and final scores.
///         Returns the result as a double value.
///     -Override the method ToString():
///         Build and return a string a string representation of 
///         all of the grading values including each quiz, midterm, 
///         final, overall grade, and letter grade.
///     -Override the method Equals():
///         Checks if this student record is equal to another student record.
///         Return true if each quiz, midterm, and final have the same score; false otherwise.
/// 2) Creata a Tester class (Implement Main):
///     -Create five different student record.
///     -Print the ToString of each object.
///     -Pause the screen.
///     

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6aLab
{
    class Lecture6aLab
    {
        static void Main(string[] args)
        {
            //Create five different student record.
            StudentRecord studentRecord1 = new StudentRecord(10, 10, 10, 100, 100);
            StudentRecord studentRecord2 = new StudentRecord(9, 10, 10, 90, 90);
            StudentRecord studentRecord3 = new StudentRecord(9, 7, 8, 95, 90);
            StudentRecord studentRecord4 = new StudentRecord(6, 6, 7, 80, 70);
            StudentRecord studentRecord5 = new StudentRecord(5, 7, 6, 70, 60);

            //Print the ToString of each object.
            Console.WriteLine(studentRecord1);
            Console.WriteLine(studentRecord2);
            Console.WriteLine(studentRecord3);
            Console.WriteLine(studentRecord4);
            Console.WriteLine(studentRecord5);

            //Pause the screen.
            Console.ReadLine();
        }
    }
}
