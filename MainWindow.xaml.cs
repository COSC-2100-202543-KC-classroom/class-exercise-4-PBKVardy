// Author:  Kyle Vardy
// Created: October 29, 2025
// Updated: October 30, 2025
// Description:
// User interface allowing you to create and view a list of vehicles

using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace CarList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Cars list as an observable collection so the list will auto update when I add to it
        ObservableCollection<Vehicle> vehicles = new ObservableCollection<Vehicle>();
        // Variable to store if its the first run, if is, don't do anything for the type change event
        private bool firstRun = true;

        public MainWindow()
        {
            InitializeComponent();

            // Set the item source to be the cars collection
            vehicleList.ItemsSource = vehicles;
            
            // Setup year combobox
            // Loop through each number between this year and this year - 50
            for (int i = DateTime.Now.Year; i >= DateTime.Now.Year - 50; i--)
            {
                // Add the year to the comboBox
                comboBoxYear.Items.Add(i);
            }
        }

        /// <summary>
        /// Creates a new car based on the provided infromation and add it to the data grid
        /// </summary>
        private void EnterButtonClick(object sender, RoutedEventArgs e)
        {
            // If everything is filled
            if (comboBoxYear.SelectedIndex != -1 && comboBoxMake.SelectedIndex != -1 && txtModel.Text != "" && txtPrice.Text != "") {
                // and price can be a decimal
                if (decimal.TryParse(txtPrice.Text, out decimal price))
                {
                    price = Math.Round(price, 2);
                    // Create the new car then add it to the list
                    switch (comboBoxType.SelectedIndex)
                        {
                            // 0 == car
                            // 1 == tricycle
                            case (0):
                                vehicles.Add(new Car(comboBoxMake.Text, txtModel.Text, int.Parse(comboBoxYear.Text), price, checkBoxNew.IsChecked.Value, false));
                                break;
                            case (1):
                            vehicles.Add(new Tricycle(comboBoxMake.Text, txtModel.Text, int.Parse(comboBoxYear.Text), price, checkBoxNew.IsChecked.Value, double.Parse(txtHandleBarHeight.Text)));
                                break;
                        }
                } 
                // Otherwise when the price is not a decimal
                else
                {
                    // Show the error
                    MessageBox.Show("Price must be a valid number");
                }
            } 
            // Otherwise when not everything is filled
            else
            {
                // Show the error
                MessageBox.Show("All fields must be filled");
            }
        }

        /// <summary>
        /// Resets the window
        /// </summary>
        private void ResetButtonClick(object sender, RoutedEventArgs e)
        {
            // Reset everything
            comboBoxMake.SelectedIndex = -1;
            comboBoxYear.SelectedIndex = -1;
            txtModel.Text = "";
            txtPrice.Text = "";
            checkBoxNew.IsChecked = false;
            Car.ResetCount();
            vehicles.Clear();
        }

        /// <summary>
        /// Exits the program
        /// </summary>
        private void ExitButtonClick(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Changes visibility of handle bar height and clears it when the type is changed
        /// </summary>
        private void TypeChangedEvent(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // Hacky fix for the handlebar not existing when the event is first called
            if (firstRun) firstRun = false;
            else
            {
                ComboBox typeBox = (ComboBox)sender;
                switch (typeBox.SelectedIndex)
                {
                    // 0 == car
                    // 1 == tricycle
                    case (0):
                        txtHandleBarHeight.Visibility = Visibility.Hidden;
                        labelHandleBarHeight.Visibility = Visibility.Hidden;
                        txtHandleBarHeight.Text = "";
                        break;
                    case (1):
                        txtHandleBarHeight.Visibility = Visibility.Visible;
                        labelHandleBarHeight.Visibility = Visibility.Visible;
                        break;
                }
            }
        }
    }
}