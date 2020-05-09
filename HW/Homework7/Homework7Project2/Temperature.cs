/// Homework No. 07 Exercise No. 02
/// File Name:      Temperature.cs
/// @author:        Karina Elias
/// Date:           Oct 21, 2019
/// 
/// Problem Statement: Write a Temperature class that has two
/// instance variables: a temperature value (a floating-point
/// number) and a character for the scale, either C for Celsius
/// or F for Fahrenheit. The class should have 4 constructor
/// methods: one for each instance variable (assume zero degress
/// if no value is specified and Celsius if no scale is specified),
/// one with two parameters for the two instance variables,
/// and a no-argument constructor (set to zero degrees Celsius).
/// 
/// 
/// Overall Plan
/// 1. Write Temperature class
/// 2. Define instance variables
/// 3. Write 4 constructors
/// 4. Write methods
/// 5. Create Temperature objects
/// 6. Test all methods and constructors
/// 
/// Classes needed and Purpose (Input, Processing, Output)
/// main class - TemperatureDriver.cs
/// Temperature class - Temperature.cs

/// Import necessay C# or user-defined packages

/// Create main class and objects needed to implement tasks
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7Project2
{
    class Temperature
    {
        // instance variables
        private double temp;
        private char scale;

        // constructors
        /** temp instance variable */
        public Temperature(double temp)
        {
            this.temp = temp;
            scale = 'C';
        }

        /** scale instance variable */
        public Temperature(char scale)
        {
            temp = 0;
            this.scale = scale;
        }

        /** full constructor */
        public Temperature(double temp, char scale)
        {
            this.temp = temp;
            this.scale = scale;
        }

        /** no-argument constructor */
        public Temperature()
        {
            temp = 0;
            scale = 'C';
        }

        // methods
        /** GetTempC */
        public double GetTempC()
        {
            double tempC = temp;
            if(Char.ToUpper(scale) == 'F')
            {
                tempC = (temp - 32) * (Convert.ToDouble(5) / 9);
            }
            return Math.Round(tempC, 1);
        }

        /** GetTempF */
        public double GetTempF()
        {
            double tempF = temp;
            if (Char.ToUpper(scale) == 'C')
            {
                tempF = (temp * (Convert.ToDouble(9) / 5)) + 32;
            }
            return Math.Round(tempF, 1);
        }

        /** SetTemp */
        public void SetTemp(double temp)
        {
            this.temp = temp;
        }

        /** SetScale */
        public void SetScale(char scale)
        {
            scale = Char.ToUpper(scale);
            this.scale = scale;
        }

        /** SetAll */
        public void SetAll(double temp, char scale)
        {
            this.temp = temp;
            scale = Char.ToUpper(scale);
            this.scale = scale;
        }

        /** ToString */
        public override string ToString()
        {
            return String.Format("Temperature: {0}°{1}", temp, Char.ToUpper(scale));
        }

        /** Equals */
        public override bool Equals(object obj)
        {
            if((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Temperature t = (Temperature)obj;
                return GetTempF() == t.GetTempF();
            }
        }
    }
}
