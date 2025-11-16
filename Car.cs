// Author:  Kyle Chapman and Kyle Vardy
// Created: October 1, 2025
// Updated: October 30, 2025
// Description:
// Object storing infromation about a car extending the vehicle class

namespace CarList
{
    /// <summary>
    /// Stores info on cars in memory
    /// </summary>
    internal class Car : Vehicle
    {
        // Setup local properties
        private bool isElectric;

        /// <summary>
        /// Fill all the variables about the car
        /// </summary>
        /// <param name="make">The make of the car</param>
        /// <param name="model">The model of the car</param>
        /// <param name="year">The year the car was made</param>
        /// <param name="price">The price of the car</param>
        /// <param name="isNew">If the car is used or not</param>
        /// <param name="isElectric">If the car is electric or not</param>
        public Car(string make, string model, int year, decimal price, bool isNew, bool isElectric) : base(make, model, year, price, isNew)
        {
            this.isElectric = isElectric;
        }

        /// <summary>
        /// Defualt constructor
        /// </summary>
        public Car() : base()
        {
            this.isElectric = false;
        }
        
        /// <summary>
        /// Getter and setter for isElectric property
        /// </summary>
        public bool IsElectric
        {
            get
            {
                return isElectric;
            }

            set
            {
                isElectric = value;
            }
        }
        
        public string Type
        {
            get
            {
                return "Car";
            }
        }

        /// <summary>
        /// Returns a string of all the properties in the class
        /// </summary>
        /// <returns>A human readable string of all properties in the class</returns>
        public override string ToString()
        {
            return base.ToString() + String.Format(", Electric: %s", isElectric);
        }
    }
}