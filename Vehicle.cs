// Author:  Kyle Vardy
// Created: October 30, 2025
// Updated: October 30, 2025
// Description:
// An abstract object that stores infromation on a vehicle to demonstrate inheritance

namespace CarList
{
    /// <summary>
    /// Abstract class for a list to display different types of vehicles
    /// </summary>
    internal abstract class Vehicle
    {
        // setup local properties
        private static int count = 0;
        private readonly int id;
        private string make;
        private string model;
        private int year;
        private decimal price;
        private bool isNew;

        /// <summary>
        /// Fill all the properties about the vehicle
        /// </summary>
        /// <param name="make">The make of the vehicle</param>
        /// <param name="model">The model of the vehicle</param>
        /// <param name="year">The year the vehicle was made</param>
        /// <param name="price">The price of the vehicle</param>
        /// <param name="isNew">If the vehicle is used or not</param>
        public Vehicle(string make, string model, int year, decimal price, bool isNew) : this()
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
            this.isNew = isNew;
        }

        /// <summary>
        /// Defualt constructor
        /// </summary>
        public Vehicle()
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
        /// Getter and setter for the IsNew property 
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
        /// Getter for the id property 
        /// </summary>
        public int Id
        {
            get
            {
                return id;
            }
        }

        /// <summary>
        /// Getter and setter for the make property 
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
        /// Getter and setter for the Model property 
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
        /// Getter and setter for the Year property 
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
        /// Getter and setter for the Price property 
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
        /// Static getter for the Count property 
        /// </summary>
        public static int Count
        {
            get
            {
                return count;
            }
        }

        public string Type
        {
            get
            {
                return "Vehicle";
            }
        }

        /// <summary>
        /// Returns a string of all the properties in the class
        /// </summary>
        /// <returns>A human readable string of all properties in the class</returns>
        public override string ToString()
        {
            return String.Format("ID: %s, Make: %s, Model: %s, Year: %s, Price: New: %s", id, make, model, year, price, isNew);
        }
    }
}
