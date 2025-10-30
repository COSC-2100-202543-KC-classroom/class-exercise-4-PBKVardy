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
                comboBoxYear.Items.Add(i);
            }
        }

        private void EnterButtonClick(object sender, RoutedEventArgs e)
        {
            if (comboBoxYear.SelectedIndex != -1 && comboBoxMake.SelectedIndex != -1 && txtModel.Text != "" && txtPrice.Text != "") {
                if (decimal.TryParse(txtPrice.Text, out decimal price))
                {
                    cars.Add(new Car(comboBoxMake.Text, txtModel.Text, int.Parse(comboBoxYear.Text), price, checkBoxNew.IsChecked.Value));
                } else
                {
                    MessageBox.Show("Price must be a valid number x.xx");
                }
            } else
            {
                MessageBox.Show("All fields must be filled");
            }
        }
    }
}