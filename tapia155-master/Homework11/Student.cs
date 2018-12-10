/// Lecture: 11	        Exercise No. Homework11
/// File Name:          Student.cs
/// @author:            Angel Tapia
/// Date:               November 25, 2018
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    //Student is a concrete class that represent a student
    //by first name; last name; and student score.
    class Student : IComparable
    {
        //Instance variables
        private string firstName;
        private string lastName;
        private int score;

        //Default constructor
        public Student()
        {
            SetFirstName("");
            SetLastName("");
            SetScore(0);
        }
        //Full constructor
        public Student(string firstName, string lastName, int score)
        {
            SetFirstName(firstName);
            SetLastName(lastName);
            SetScore(score);
        }

        //Setter for firstName
        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }
        //Setter for lastName
        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }
        //Setter for score
        public void SetScore(int score)
        {
            this.score = score;
        }        

        //Getter for firstName
        public string GetFirstName()
        {
            return this.firstName;
        }
        //Getter for lastName
        public string GetLastName()
        {
            return this.lastName;
        }

        //Getter for score
        public int GetScore()
        {
            return this.score;
        }

        //Compares this objects score with the given object's score for sorting order.
        //Returns < 0 if this.score < obj.score; 0 if this.score == obj.score; else return > 0 .
        //throws InvalidCastException if the passed obj is not an instance of the Student class.
        public int CompareTo(object obj)
        {
            if (null == obj || GetType() != obj.GetType())
            {
                throw new InvalidCastException();
            }
            return score - ((Student)obj).score;
        }

        //Builds and returns a string representation of a student: first name, last name, and score
        public override string ToString()
        {
            return String.Format("{0, -10} {1, -10} {2, -10}", firstName, lastName, score);
        }

        //Compares this students with another student.
        //Returns true if both score, firstName, and lastName are equivalent; false otherwise.
        public override bool Equals(object obj)
        {
            if (null == obj || GetType() != obj.GetType())
            {
                return false;
            }
            Student other = (Student)obj;
            return score == other.score 
                && firstName.Equals(other.firstName)
                && lastName.Equals(other.lastName);
        }
    }
}
