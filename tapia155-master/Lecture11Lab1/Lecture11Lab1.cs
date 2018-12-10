/// Lecture11	        Exercise No. Lab1
/// File Name:          Lecture11Lab1.cs
/// @author:            Angel Tapia
/// Date:               November 19, 2018
/// 
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11Lab1
{
    class Lecture11Lab1
    {
        class NameInfo
        {
            public int Rank { get; set; }
            public int Count { get; set; }
        }

        static void Main(string[] args)
        {
            //Create two dictionary to store boy and girl names
            Dictionary<string, NameInfo> boyNames = ReadNameInfo("boynames.txt");
            Dictionary<string, NameInfo> girlNames = ReadNameInfo("girlnames.txt");

            string name = "";//User input
            do
            {
                //Get input
                Console.Write("Enter name or x to exit: ");
                name = Console.ReadLine();

                if (boyNames.ContainsKey(name))//Search in boy names
                {
                    NameInfo info = boyNames[name];
                    Console.WriteLine(String.Format("{0} is ranked {1} in popularity among boys with {2} namings.", name, info.Rank, info.Count));
                }
                else if (girlNames.ContainsKey(name))//Search in girl names
                {
                    NameInfo info = girlNames[name];
                    Console.WriteLine(String.Format("{0} is ranked {1} in popularity among girls with {2} namings.", name, info.Rank, info.Count));
                }
                else if (!name.ToLower().Equals("x") && !name.Trim().Equals(""))// Name no found
                {
                    Console.WriteLine(String.Format("{0} is not ranked among the top 2000 names.", name));
                }

            } while (!name.ToLower().Equals("x"));

            //Display End of the program
            Console.WriteLine("End of the program!");
            Console.ReadLine();
        }

        //Read a name file with format name rank and stores it in a dictionary with key name and value NameInfo
        static Dictionary<string, NameInfo> ReadNameInfo(string fileName)
        {
            Dictionary<string, NameInfo> info = new Dictionary<string, NameInfo>();

            using (StreamReader streamIn = new StreamReader(fileName))
            {
                string line = null;
                int count = 1;
                while ((line = streamIn.ReadLine()) != null)
                {
                    string[] lineData = line.Split(new char[]{ ' ', '\t' });
                    NameInfo nameInfo = new NameInfo();

                    Int32.TryParse(lineData[1], out int rank);
                    nameInfo.Rank = rank;
                    nameInfo.Count = count++;

                    if (!info.ContainsKey(lineData[0]))
                    {
                        info.Add(lineData[0], nameInfo);
                    }
                }
            }
            return info;
        }
    }
}
