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

namespace WpfApp3
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

        private void ez1_Checked(object sender, RoutedEventArgs e)
        {
            elo.Text = "ezzzz";
            elo.Foreground = new SolidColorBrush(Colors.Red);
        }

        private void jol1_Checked(object sender, RoutedEventArgs e)
        {
            elo.Text = "nicea";
            elo.Foreground = new SolidColorBrush(Colors.Blue);
        }

        private void beka1_Checked(object sender, RoutedEventArgs e)
        {
            elo.Text = "seven";
            elo.Foreground = new SolidColorBrush(Colors.Green);
        }

        private void v12_Checked(object sender, RoutedEventArgs e)
        {
            var uriSource = new Uri("nissan.jpg", UriKind.Relative);
            gtr.Source = new BitmapImage(uriSource);
            
        }
        private void v12_Unchecked(object sender, RoutedEventArgs e)
        {
            var uriSource = new Uri("toyota.jpg", UriKind.Relative);
            gtr.Source = new BitmapImage(uriSource);
        }
       
    }
}