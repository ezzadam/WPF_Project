using MahApps.Metro.Controls;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public string user { get; set; }
        public string version { get; set; }
        public string recipe { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            user = $"Designer";
            version = $"2.0.0";
            recipe = $"Recipe";
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            FirstFlyout.IsOpen = true;
        }
    }
}
