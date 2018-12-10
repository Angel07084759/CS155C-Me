/// Lecture10	        Exercise No. Lab1
/// File Name:          Lecture10Lab1.cs
/// @author:            Angel Tapia
/// Date:               November 5, 2018
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10Lab1
{
    class Lecture10Lab1
    {
        //Requests and checks that non-empty string is input as a name.
        public static string GetValidName()
        {
            string name;
            Console.Write("Enter name: ");

            while (!((name = Console.ReadLine().Trim()).Length > 0))
            {
                Console.Write("Please Enter a name: ");
            }
            return name;
        }

        //Request and checks that the user enters a number with ten digits
        public static ulong GetValidNumber()
        {
            ulong number;
            Console.Write("Enter number: ");
            ulong.TryParse(Console.ReadLine(), out number);

            while (!(number >= 1000000000 && number <= 9999999999))
            {
                Console.Write("Please enter a valid phone number of ten digits : ");
                ulong.TryParse(Console.ReadLine(), out number);
            }
            return number;
        }

        //Searches a phone number in the given dictionary
        public static ulong FindNumber(Dictionary<string, ulong> dic)
        {
            string name;
            ulong number = 0; ;
            if (dic.ContainsKey((name = GetValidName())))
            {
                number = dic[name];
                Console.WriteLine(name + "'s is " + number);
                return number;
            }
            Console.WriteLine("\"" + name + "\" does not exists.");
            return number;
        }

        //Adds a phone number in the given dictionary
        public static string AddNumber(Dictionary<string, ulong> dic)
        {
            string name;
            dic.Add((name = GetValidName()), GetValidNumber());
            return name;
        }

        //Deletes a phone number in the given dictionary
        public static string DeleteNumber(Dictionary<string, ulong> dic)
        {
            string name;
            ulong number = 0; ;
            if (dic.ContainsKey((name = GetValidName())))
            {
                number = dic[name];
                dic.Remove(name);
                Console.WriteLine(name + ": " + number + " has been removed successfully!" );
                return name;
            }
            Console.WriteLine("\"" + name + "\" does not exists.");
            return name;
        }

        public static int Menu()
        {
            Console.WriteLine(" ------------------ ");
            Console.WriteLine("|[1] Find Number   |");
            Console.WriteLine("|[2] Add Number    |");
            Console.WriteLine("|[3] Delete Number |");
            Console.WriteLine("|[0] Exit          |");
            Console.WriteLine(" ------------------ ");
            int choice;
            string input = Console.ReadLine().Trim();
            int.TryParse(input, out choice);
            
            return input.Equals(choice +"") ? choice : -1;
        }

        //Test a dictionary that contains phone numbers
        static void Main(string[] args)
        {
            Dictionary<string, ulong> dic = new Dictionary<string, ulong>();
            int choice = -1;
            while ((choice = Menu()) != 0)
            {
                switch(choice)
                {
                    case 1:
                        FindNumber(dic);                        
                        break;
                    case 2:
                        AddNumber(dic);
                        break;
                    case 3:
                        DeleteNumber(dic);
                        break;
                    default:
                        Console.WriteLine("Please enter a valid Choice... ");
                        break;
                }
            }
            Console.WriteLine("End of the program!");
            Console.ReadLine();

        }
    }
}
