/// Lecture: 11	        Exercise No. Homework11
/// File Name:          StudentStats.cs
/// @author:            Angel Tapia
/// Date:               November 25, 2018
/// 
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    //StudentStats reads student data from a file.
    //This data is used to calculate the average and median student score.
    class StudentStats
    {
        //Private array of type char that store the delimiter for the file to be read.
        private static readonly char[] DELIMITER = { ' ', '\t' };

        //private list to store temp data from the file.
        private List<Student> studentList = new List<Student>();

        //Full constructor: reads student data; populate and sort a student list.
        public StudentStats(string fileNameIn)
        {
            ReadStudentFile(fileNameIn);
            DisplayStudentList();
            studentList.Sort();

        }

        //Reads a student data to populate the list of student.
        //Throws corrupted file Exception if the given file is corrupted.
        public void ReadStudentFile(string fileName)
        {
            using (StreamReader streamIn = new StreamReader(fileName))
            {
                string line = null;
                while ((line = streamIn.ReadLine()) != null)
                {
                    string[] lineData = line.Split(DELIMITER);
                    string fName = lineData[0];
                    string lName = lineData[1];
                    if (!Int32.TryParse(lineData[2], out int score))
                    {
                        throw new Exception("file '" + fileName + "' is corrupted!");
                    }
                    studentList.Add(new Student(fName, lName, score));
                }
            }
        }

        //Calculates and returns the average student score from the populated student list.
        public double GetAverageScore()
        {
            double total = 0;
            double count = 0;
            foreach(Student student in studentList)
            {
                count++;
                total += student.GetScore();
            }
            return count == 0 ? -1 : total / count;
        }

        //Calculates and returns the median student score from the populated student list.
        public double GetMedianScore()
        {
            if (studentList.Count == 0)
            {
                return -1;
            }

            int index = (studentList.Count / 2);

            if (studentList.Count == 1 || studentList.Count % 2 != 0)
            {
                return studentList[index].GetScore();
            }
            
            return (studentList[index - 1].GetScore()  + studentList[index].GetScore())  / 2.0;
        }

        //Writes the average and median student score to the given file.
        public void WriteStudentStats(string fileName)
        {
            using (StreamWriter streamOut = new StreamWriter(fileName, false))
            {
                string average = "AVERAGE: " + GetAverageScore();
                string median = "MEDIAN:  " + GetMedianScore();
                Console.WriteLine(average);
                Console.WriteLine(median);
                streamOut.WriteLine(average);
                streamOut.WriteLine(median);
            }
        }

        //Display the content of studentList.
        public void DisplayStudentList()
        {
            Console.WriteLine("{0, -10} {1, -9} {2}", "F_NAME", "L_NAME", "SCORE");
            foreach (Student student in studentList)
            {
                Console.WriteLine(student);
            }
        }
    }
}
