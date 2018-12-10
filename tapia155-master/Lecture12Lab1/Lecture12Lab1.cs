/// Lecture12	        Exercise No. Lab1
/// File Name:          Lecture12Lab1.cs
/// @author:            Angel Tapia
/// Date:               November 26, 2018
///
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture12Lab1
{
    class Lecture12Lab1
    {
        //Delegate definition
        delegate string MyDelegate(string aString, int aInt);

        //Build and return the given name and id as a ToString
        static string NameAndIdToString(string name, int id)
        {
            return "NAME: " +  name + "  ID : " + id;
        }

        //Encode and returns the name with the given key
        static string encodeNameAndId(string name, int key)
        {
            string temp = "";
            for (int i = 0; i < name.Length; i++)
            {
                temp += name.ElementAt(i) + "" + key;
            }
            return temp;
        }

        //Tests the defined delegate with the two implemented method
        static void Main(string[] args)
        {
            MyDelegate delegateTest = NameAndIdToString;
            Console.WriteLine(delegateTest("Angel", 0));

            delegateTest = encodeNameAndId;
            Console.WriteLine(delegateTest("Angel", 0));

            Console.ReadLine();

        }
    }
}
