/// Lecture: 12	        Exercise No. Homework13
/// File Name:          Homework13.cs
/// @author:            Angel Tapia
/// Date:               December 3, 2018
/// Problem Statement:  This program uses query expressions to get and print 
///                     a list of persons that are overweight according to the
///                     formula of Body Mass Index (BMI).
///                     
/// Algorithm:
/// Create a person:
///     Create properties for:
///         string FirstName  
///         string LastName 
///         int Age 
///         int Height 
///         int Weight
///     Create a full constructor and initialize each properties.
///     Create a Method double GetBMI():
///         if Height == 0 return 0 else return (703.0 * Weight) / (Height * Height);
///     Override the ToString to return all of the values of the person properties GetBMI
/// Implement Main:
///     Create a list of 15 random persons
///     Create a query of overweight persons:
///         from person in personList where person.GetBMI() > 25 select person;
///     Print query of overweight persons
///     Create a query of ideal weight persons:
///         from person in personList where person.GetBMI() > 20 && person.GetBMI() < 25 select person;
///     Print query of list of  persons
///     
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    public class Person
    {
        //Full constructor
        public Person(string fName, string lName, int age, int height, int weight)
        {
            FirstName = fName;
            LastName = lName;
            Age = age;
            Height = height;
            Weight = weight;
        }
        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        //calculate BMI
        public double GetBMI()
        {
            if (Height == 0)
                return 0;
            return (703.0 * Weight) / (Height * Height);
        }
        //ToString
        public override string ToString()
        {
            return String.Format("{0, -10}{1, -10}{2, -10}{3, -10}{4, -10}{5:N2}", 
                FirstName, LastName, Age, Height, Weight, GetBMI());
        }
    }
    
    //Executes Main
    class Homework13
    {
        static void Main(string[] args)
        {
            //Createing list of person
            List<Person> personList = new List<Person>();
            Console.WriteLine("{0, -10}{1, -10}{2, -10}{3, -10}{4, -10}{5, -10}", 
                "F_Name", "L_NAME", "AGE", "HEIGHT", "WEIGHT", "BMI");
            personList.Add(new Person("Angel",      "Tapia",    30, 65, 175));
            personList.Add(new Person("Jessica",    "Sanchez",  20, 60, 145));
            personList.Add(new Person("Arnold",     "Palmer",   65, 78, 150));
            personList.Add(new Person("Joy",        "Torres",   40, 72, 160));
            personList.Add(new Person("Emily",      "Vasquez",  33, 64, 200));
            personList.Add(new Person("George",     "Wong",     28, 58, 155));
            personList.Add(new Person("Gabriela",   "Smith",    19, 55, 130));
            personList.Add(new Person("Olga",       "Ordones",  21, 69, 120));
            personList.Add(new Person("Alma",       "Guzman",   45, 71, 115));
            personList.Add(new Person("Jacquelin",  "Azul",     72, 56, 120));
            personList.Add(new Person("Tara",       "Smith",    27, 58, 132));
            personList.Add(new Person("Sara",       "Perez",    80, 58, 110));
            personList.Add(new Person("Samuel",     "Diaz",     12, 40,  90));
            personList.Add(new Person("Ismael",      "Arango",  90, 50, 100));
            personList.Add(new Person("Jose",       "Hernandez",87, 61, 115));

            //querying and printing overweight people
            IEnumerable<Person> overweight = from person in personList where person.GetBMI() > 25 select person;
            Console.WriteLine("************ Overweight People *************");
            foreach (Person person in overweight)
            {
                Console.WriteLine(person);
            }

            //querying and printing ideal weight people
            IEnumerable<Person> idelWeight = from person in personList where person.GetBMI() > 20 && person.GetBMI() < 25 select person;
            Console.WriteLine("\n************ Ideal weight People **********");
            foreach (Person person in idelWeight)
            {
                Console.WriteLine(person);
            }

            Console.ReadKey();
        }
    }
}
