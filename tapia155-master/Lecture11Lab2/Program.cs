/// Lecture11	        Exercise No. Lab2
/// File Name:          Lecture11Lab2.cs
/// @author:            Angel Tapia
/// Date:               November 19, 2018
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11Lab2
{
    class Program
    {

        //Uses optional parameters to specify the size of pizza.
        static int Size(int inChSize = 10)
        {
            return inChSize;
        }

        //Uses optional parameters to specify the cut of a pizza.
        static int Cut(int slice = 8)
        {
            return slice;
        }

        //Uses named parameters to choose qty of cheese.
        static string Cheese(string cheese, int qty)
        {
            return String.Format("CHEESE: {0}  QTY:{1}", cheese, qty);
        }

        //Uses named parameters to choose qty of each topping.
        static string Toppings(int pepperoni, int ham, int salamy)
        {
            return String.Format("PEPPERONI: {0}  HAM: {1}  SALAMY: {2}", pepperoni, ham, salamy);
        }
        
        //Uses variable parameters to get a list of names.
        static string SharingNames(params string[] names)
        {
            string temp = "";
            foreach (string name in names)
            {
                temp += name + ", "; 
            }
            return temp;
        }

        //Uses variable parameters to get a list of donations.
        static string DonationList(params double[] donations)
        {
            string temp = "";
            foreach (double donation in donations)
            {
                temp += donation + ", ";
            }
            return temp;
        }

        //Main: Testes method with optional, named, and variable parameters.
        static void Main(string[] args)
        {
            Console.WriteLine("===== Pizza1 Using Default parameters =====");
            Console.WriteLine("Pizza1 Default Size:         {0}", Size());
            Console.WriteLine("Pizza1 Default Cut:          {0}", Cut());
            Console.WriteLine("Pizza1 Default Cheese:       {0}", Cheese(cheese: "Mozzarella", qty: 1));
            Console.WriteLine("Pizza1 Default Toppings:     {0}", Toppings(pepperoni: 1, ham: 2, salamy: 3));
            Console.WriteLine("Pizza1 Default SharingNames: {0}", SharingNames("Angel", "Jenny"));
            Console.WriteLine("Pizza1 Default DonationList: {0}", DonationList(2.50, 2.14, 3.34, 2.29, 5.00));


            Console.WriteLine("\n===== Pizza2 Using optional, named, and variable parameters =====");
            Console.WriteLine("Pizza2 Size:         {0}", Size(24));
            Console.WriteLine("Pizza2 Cut:          {0}", Cut(16));
            Console.WriteLine("Pizza2 Cheese:       {0}", Cheese(qty: 1, cheese: "Jack"));
            Console.WriteLine("Pizza2 Toppings:     {0}", Toppings(ham: 2, pepperoni: 1, salamy: 3));
            Console.WriteLine("Pizza2 SharingNames: {0}", SharingNames("Angel", "Jenny", "Bianca", "Diana", "Iris"));
            Console.WriteLine("Pizza2 DonationList: {0}", DonationList(2.50, 2.14, 3.34, 2.29, 5.00, 1.10, 2, 45, 3, 40));

            Console.ReadLine();
        }
    }
}
