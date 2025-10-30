using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CarList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Cars list as an observable collection so the list will auto update when I add to it
        ObservableCollection<Car> cars = new ObservableCollection<Car>();

        public MainWindow()
        {
            InitializeComponent();

            // Set the item source to be the cars collection
            carsList.ItemsSource = cars;
            
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
                    // Create the new car then add it to the list
                    cars.Add(new Car(comboBoxMake.Text, txtModel.Text, int.Parse(comboBoxYear.Text), price, checkBoxNew.IsChecked.Value));
                } 
                // Otherwise when the price is not a decimal
                else
                {
                    // Show the error
                    MessageBox.Show("Price must be a valid number x.xx");
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
            comboBoxMake.SelectedIndex = -1;
            comboBoxYear.SelectedIndex = -1;
            txtModel.Text = "";
            txtPrice.Text = "";
            checkBoxNew.IsChecked = false;
            Car.ResetCount();
            cars.Clear();
        }

        /// <summary>
        /// Exits the program
        /// </summary>
        private void ExitButtonClick(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}