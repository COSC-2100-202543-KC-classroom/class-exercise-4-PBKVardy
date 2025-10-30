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

        List<Car> cars = new List<Car>();

        public MainWindow()
        {
            InitializeComponent();

            cars.Add(new Car("T", "e", 2, 7, false));

            carsList.ItemsSource = cars;
            
            // Setup year combobox
            for (int i = DateTime.Now.Year; i >= DateTime.Now.Year - 50; i--)
            {
                comboBoxYear.Items.Add(i);
            }

        }
    }
}