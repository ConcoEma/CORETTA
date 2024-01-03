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

namespace Girovagando
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

            private void ViaggiClick(object sender, RoutedEventArgs e)
            {
                // Apri la finestra ViaggiWindow
                Window1 ViaggiWindow = new Window1();
                ViaggiWindow.Show();
            }
            private void ChisiamoClick(object sender, RoutedEventArgs e)
            {
                Window3 Chisiamo = new Window3();
                Chisiamo.Show();
            }
        private void HomeClick(object sender, RoutedEventArgs e)
        {
            // Chiudi la finestra corrente
            this.Close();

            // Crea e apri una nuova finestra principale
            MainWindow Home = new MainWindow();
            Home.Show();
        }


        private void InsertDate_Click(object sender, RoutedEventArgs e)
            {
                DateTime selectedDate = datePicker.SelectedDate ?? DateTime.Now;
                MessageBox.Show($"Data selezionata: {selectedDate.ToShortDateString()}");
            }
        }
    }
