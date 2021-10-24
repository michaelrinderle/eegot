using eegot.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace eegot
{
    public partial class MainWindow : Window
    {
        public MainWindowViewModel vm { get; set; }
        public static Frame? _frame { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = vm = new MainWindowViewModel();

            _frame = _mainFrame;
            _frame.Navigate(new Views.Emotive());
        }

        private void MenuItem_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
