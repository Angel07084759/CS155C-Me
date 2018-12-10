/// Chapter No. Week8	Exercise No. Homework7_1
/// File Name:          Temperature.cs
/// @author:            Angel Tapia
/// Date:               October 22, 2018
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_2
{
    class Temperature
    {
        public const char CELSIUS = 'C'; //scale Celsius
        public const char FAHRENHEIT = 'F'; //scale Fahrenheit

        private char scale;//Either F for Fahrenheit or C for Celsius
        private double temperature;//a temperature floating-point value

        //Default constructor that sets scale to Celsius and temperature to 0
        public Temperature()
        {
            SetTemperature(CELSIUS, 0);
        }

        //Constructor that sets scale to the given value and temperature to 0
        public Temperature(char scale) : this()
        {
            SetScale(scale);
        }

        //Constructor that sets temperature to the given value and scale to Celsius
        public Temperature(double temperature) : this()
        {
            SetTemperature(temperature);
        }

        //Constructor that sets temperature and scale to the given value
        public Temperature(char scale, double temperature) : this()
        {
            SetTemperature(scale, temperature);
        }

        //Setter for scale: Sets scale ONLY if the given value is either F or C
        public void SetScale(char scale)
        {
            char temp = (scale + "").ToUpper().ElementAt(0);

            if (temp == CELSIUS || temp == FAHRENHEIT)
            {
                this.scale = temp;
            }
        }

        //Setter for temperature.
        public void SetTemperature(double temperature)
        {
            this.temperature = temperature;
        }

        //Sets the scale and temperature using the setters for scale and temperature.
        public void SetTemperature(char scale, double temperature)
        {
            SetScale(scale);
            SetTemperature(temperature);
        }

        //Returns the current scale value.
        public char GetScale()
        {
            return scale;
        }

        //Calculates and returns the current temperature in Celsius,
        //using the formula: (temperature - 32) * 5.0 / 9.0
        public double GetTempCel()
        {
            if (scale == CELSIUS)
            {
                return temperature;
            }
            return Math.Round( ((temperature - 32) * 5.0 / 9.0), 2);
        }

        //Calculates and returns the current temperature in Fahrenheit,
        //using the formula: (temperature * 9.0 / 5.0) + 32
        public double GetTempFah()
        {
            if (scale == FAHRENHEIT)
            {
                return temperature;
            }
            return Math.Round( ((temperature * 9.0 / 5.0) + 32) , 2);
        }

        //Builds and returns a string representation of the current object.
        public override string ToString()
        {
            return Math.Round(temperature, 2) + "°" + scale;
        }

        //Compares this and another Odometer object.
        //Returns true if their getTempFah method are equals.
        public override bool Equals(object obj)
        {
            if (null == obj || GetType() != obj.GetType())
            {
                return false;
            }
            Temperature other = (Temperature) obj;
            return GetTempFah() == other.GetTempFah();
        }

    }
}
