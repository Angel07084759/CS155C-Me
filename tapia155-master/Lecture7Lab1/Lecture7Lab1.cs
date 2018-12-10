/// Chapter #.Lecture7  Exercise No. Lab1
/// File Name:          Lecture7Lab1.cs
/// @author:            Angel Tapia
/// Date:               October 15, 2018
/// Problem Statement:  This program 
/// Algorithm:
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture7Lab1
{
    class Lecture7Lab1
    {
        static void Main(string[] args)
        {
            //Local variables for user's input
            int size = (int) Pizza.Size.medium;
            int cheese = 0;
            int peperoni = 0;
            int ham = 0;

            //Getting inputs from the user
            Console.WriteLine("Make your pizza...");
            Console.Write("Enter size (small=10, medium=12, or large=14): ");
            Int32.TryParse(Console.ReadLine(), out size);
            Console.Write("Enter Cheese (Qty: 1,2,..): ");
            Int32.TryParse(Console.ReadLine(), out cheese);
            Console.Write("Enter pepperoni (Qty: 1,2,..): ");
            Int32.TryParse(Console.ReadLine(), out peperoni);
            Console.Write("Enter ham (Qty: 1,2,..): ");
            Int32.TryParse(Console.ReadLine(), out ham);

            //Building and prints the toString  of the pizza object
            Pizza pizza = new Pizza((Pizza.Size) size, cheese, peperoni, ham);
            Console.WriteLine(pizza);
            
            Console.ReadLine();
        }
    }
}
