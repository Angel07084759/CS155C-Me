/// Chapter No. Week7	Exercise No. Homework6_1
/// File Name:          Counter.cs
/// @author:            Angel Tapia
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6_1
{
    class Counter
    {
        //Instance variable to keep track of the current count.
        private int count;

        //Returns the current value of count.
        public int getCount()
        {
            return count;
        }

        //Resets count to 0.
        public void reset()
        {
            count = 0;
        }

        //Increments count by one
        //Returns false if fails to increment; true otherwise.
        public bool increment()
        {
            if ((count + 1) < 0)
            {
                return false;
            }
            count++;
            return true;
        }

        //Decrements count by one
        //Returns false if fails to decrement; true otherwise.
        public bool decrement()
        {
            if ((count - 1) < 0)
            {
                return false;
            }
            count--;
            return false;
        }
        
        //Prints to the screen the current value of count.
        public void printCount()
        {
            Console.WriteLine(count);
        }

        //Returns the current value of count as a string.
        public override string ToString()
        {
            return getCount().ToString();
        }

        //Compares this fraction with another counter
        //Returns true if this count == other.count; false otherwise
        public override bool Equals(object obj)
        {
            Counter other = (Counter)obj;
            if (null == other)
            {
                return false;
            }
            return count == other.count;
        }
    }
}
