// Author:  Kyle Chapman and Kyle Vardy
// Created: October 1, 2025
// Updated: October 29, 2025
// Description:
// Code for a WPF form to display car objects. Currently, it is purely for
// display, and shows a car's make, model, year and price. Creating the car
// class to support the function of this program is meant as an exercise.
// Functionality should exist to move through the list of car objects.
// See the Car class (which you will create in a separate file!) for more details.

namespace CarList
{
    /// <summary>
    /// Stores info on cars in memory
    /// </summary>
    internal class Car
    {
        // setup local variables
        private static int count = 0;
        private readonly int id;
        private string make;
        private string model;
        private int year;
        private decimal price;
        private bool isNew;

        /// <summary>
        /// Fill all the variables about the car
        /// </summary>
        /// <param name="make">The make of the car</param>
        /// <param name="model">The model of the car</param>
        /// <param name="year">The year the car was made</param>
        /// <param name="price">The price of the car</param>
        /// <param name="isNew">If the car is used or not</param>
        public Car(string make, string model, int year, decimal price, bool isNew) : this()
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
            this.isNew = isNew;
            this.id = count++;
        }

        /// <summary>
        /// Defualt constructor
        /// </summary>
        public Car() 
        {
            this.make = "";
            this.model = "";
            this.year = 0;
            this.price = 0;
            this.isNew = false;
            // Auto increment the id 
            this.id = count++;
        }

        /// <summary>
        /// Resets the count to 0
        /// </summary>
        public static void ResetCount()
        {
            count = 0;
        }

        /// <summary>
        /// Getter and setter for the IsNew variable 
        /// </summary>
        public bool IsNew
        {
            get
            {
                return isNew;
            }

            set
            {
                isNew = value;
            }
        }

        /// <summary>
        /// Getter for the id variable 
        /// </summary>
        public int Id
        {
            get
            {
                return id;
            }
        }

        /// <summary>
        /// Getter and setter for the make variable 
        /// </summary>
        public string Make
        {
            get
            {
                return make;
            }

            set
            {
                make = value;
            }
        }

        /// <summary>
        /// Getter and setter for the Model variable 
        /// </summary>
        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        /// <summary>
        /// Getter and setter for the Year variable 
        /// </summary>
        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        /// <summary>
        /// Getter and setter for the Price variable 
        /// </summary>
        public decimal Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        /// <summary>
        /// Static getter for the Count variable 
        /// </summary>
        public static int Count
        {
            get
            {
                return count;
            }
        }

        public override string ToString()
        {
            return String.Format("ID: %s, Make: %s, Model: %s, Year: %s, Price: New: %s", id, make, model, year, price, isNew);
        }
    }
}