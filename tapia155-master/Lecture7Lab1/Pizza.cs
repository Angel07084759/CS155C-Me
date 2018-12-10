/// Chapter #.Lecture7  Exercise No. Lab1
/// File Name:          Pizza.cs
/// @author:            Angel Tapia
/// Date:               October 15, 2018
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture7Lab1
{
    
    class Pizza
    {
        //Constant that represents the price per topping
        public const double TOPPING_PRICE = 2.00;

        //Enum for pizza size to prize
        public enum Size {small = 10, medium = 12, large = 14};
        
        //Instance variable size, cheese
        private Size size;
        private int cheese;
        private int pepperoni;
        private int ham;

        //Full Constructor
        public Pizza(Size size, int cheese, int pepperoni, int ham)
        {
            SetSize(size);
            SetCheese(cheese);
            SetPepperoni(pepperoni);
            SetHam(ham);
            
        }
        //Setters
        public void SetSize(Size size)
        {
            this.size = size;
        }
        public void SetCheese(int cheese)
        {
            this.cheese = cheese;
        }
        public void SetPepperoni(int pepperoni)
        {
            this.pepperoni = pepperoni;
        }
        public void SetHam(int ham)
        {
            this.ham = ham;
        }
        //Getters
        public Size GetSize()
        {
            return size;
        }
        public int GetCheese()
        {
            return cheese;
        }
        public int getPepperoni()
        {
            return pepperoni;
        }
        public int getHam()
        {
            return ham;
        }

        //Method that calculates the cost of the current pizza
        public double CalculateCost()
        {
            return (double) size + (cheese * TOPPING_PRICE) + (pepperoni * TOPPING_PRICE) + (ham * TOPPING_PRICE); 
        }

        //Builds and returns a string representation of a pizza
        public override string ToString()
        {
            return "COST: $" + CalculateCost() + "   SIZE: " + size.ToString() + "    CHEESE: " + cheese + "   PEPPERONI: " + pepperoni + "   HAM: " + ham;
        }

        //Returns true if this pizza is the same size and same amount of toppings as other pizza.
        public override bool Equals(object obj)
        {
            if (null == obj || GetType() != obj.GetType())
            {
                return false;
            }

            Pizza other = (Pizza)obj;
            return size == other.size && cheese == other.cheese  && pepperoni == other.pepperoni && ham == other.ham;
        }
    }
}
