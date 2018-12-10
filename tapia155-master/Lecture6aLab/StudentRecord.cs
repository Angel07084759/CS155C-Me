/// Chapter No. Week8	Exercise No. Lecture6aLab
/// File Name:          StudentRecord.cs
/// @author:            Angel Tapia
/// Date:               October 8, 2018
///     
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6aLab
{
    /// StudentRecord stores data of a student grade: (3) quizzes, 
    ///     (1) midterm , and (1) final. This class includes method
    ///     that returns an overall and letter grade.
    ///     (F < 60 <= D < 70 <= C < 80 <= B < 90 <= A)
    /// 
    class StudentRecord
    {
        //Constants variable that represent the overall percentage value.
        public const int QUIZ_MAX = 10;
        public const double QUIZZES = 0.25;
        public const double MIDTERM = 0.35;
        public const double FINAL = 0.40;

        //Instance variable for quizzes, midterm and final.
        private int[] quiz;
        private int midterm;
        private int final;

        //Default Constructor: Initializes quiz array for 3 quizzes.
        public StudentRecord()
        {
            quiz = new int[3];
        }

        //Full constructor that initializes all of the instance variables.
        public StudentRecord(int quiz1, int quiz2, int quiz3, int midterm, int final) : this()
        {
            SetQuiz(0, quiz1);
            SetQuiz(1, quiz2);
            SetQuiz(2, quiz3);
            SetMidterm(midterm);
            SetFinal(final);
        }

        //Sets score for a quiz.
        //Returns false if quiz number is out of 
        //bound in the quiz array; true otherwise.
        public bool SetQuiz(int quizNumber, int score)
        {
            if (quizNumber >= 0 && quizNumber < quiz.Length)
            {
                quiz[quizNumber] = score;
                return true;
            }
            return false;
        }

        //Sets score for midterm.
        public void SetMidterm(int score)
        {
            midterm = score;
        }

        //Sets score for final
        public void SetFinal(int score)
        {
            final = score;
        }

        //Calculates the letter grade based on the overall score
        //and returns the letter grade as a string.
        //(F < 60 <= D < 70 <= C < 80 <= B < 90 <= A)
        public string GetLetterGrade()
        {
            double overall = GetOverallGrade();

            if (overall >= 90)
            {
                return "A";
            }
            else if (overall >= 80)
            {
                return "B";
            }
            else if (overall >= 70)
            {
                return "C";
            }
            else if (overall >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        //Calculates the overall grade by adding up all of the quizzes 
        //midterm and final scores and returns the result as a double value.
        public double GetOverallGrade()
        {
            double quizzesAVG = 0.0;
            for (int i = 0; i < quiz.Length; i++)
            {
                quizzesAVG += quiz[i];
            }
            quizzesAVG = (quizzesAVG / (double)quiz.Length) * QUIZ_MAX;

            double calcQuizzes = quizzesAVG * QUIZZES;
            double calcMidterm = midterm  * MIDTERM;
            double calcFinal = final * FINAL;

            return Math.Round(calcQuizzes + calcMidterm + calcFinal, 1);
        }

        //Builds and returns a string a string representation of 
        //all of the grading values including each quiz, midterm, 
        //final, overall grade, and letter grade.
        public override string ToString()
        {
            String temp = "Quizzes: ";
            for (int i = 0; i < quiz.Length; i ++)
            {
                temp += " " + quiz[i]; 
            }
            temp += "      Midterm: " + midterm;
            temp += "      Final: " + final;
            temp += "      Overall: " + GetOverallGrade();
            temp += "      Letter Grade: " + GetLetterGrade();
            return temp;
        }

        //Checks if this student record is equal to another student record.
        //Return true if each quiz, midterm, and final have the same score; false otherwise.
        public override bool Equals(object obj)
        {
            StudentRecord other = (StudentRecord) obj;

            if (null == other)
            {
                return false;
            }

            for (int i = 0; i < quiz.Length; i++)
            {
                if (quiz[i] != other.quiz[i])
                {
                    return false;
                }
            }

            if (midterm != other.midterm || final != other.final)
            {
                return false;
            }
            return true;
        }
    }
}
