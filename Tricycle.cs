// Author:  Kyle Vardy
// Created: October 30, 2025
// Updated: October 30, 2025
// Description:
// Object storing infromation about a Tricycle extending the vehicle class

namespace CarList
{
    /// <summary>
    /// Stores info on Trycycles in memory
    /// </summary>
    internal class Tricycle : Vehicle
    {
        // Setup local properties
        private double handleBarHeight;

        /// <summary>
        /// Fill all the variables about the Tricycle
        /// </summary>
        /// <param name="make">The make of the trycycle</param>
        /// <param name="model">The model of the trycycle</param>
        /// <param name="year">The year the trycycle was made</param>
        /// <param name="price">The price of the trycycle</param>
        /// <param name="isNew">If the trycycle is used or not</param>
        /// <param name="handleBarHeight">The height of the handle bar in centimeters</param>
        public Tricycle(string make, string model, int year, decimal price, bool isNew, double handleBarHeight) : base(make, model, year, price, isNew)
        {
            this.handleBarHeight = handleBarHeight;
        }

        /// <summary>
        /// Defualt constructor
        /// </summary>
        public Tricycle() : base()
        {
            this.handleBarHeight = 0;
        }

        /// <summary>
        /// Getter and setter for handleBarHeight property
        /// Value should always be in centimeters
        /// </summary>
        public double HandleBarHeight
        {
            get
            {
                return handleBarHeight;
            }

            set
            {
                handleBarHeight = value;
            }
        }

        /// <summary>
        /// Type of vehicle to be tricycle
        /// </summary>
        public override string Type
        {
            get
            {
                return "Tricycle";
            }
        }
        
        /// <summary>
        /// Returns a string of all the properties in the class
        /// </summary>
        /// <returns>A human readable string of all properties in the class</returns>
        public override string ToString()
        {
            return base.ToString() + String.Format(", Handle Bar Height: {0}", handleBarHeight);
        }
    }
}