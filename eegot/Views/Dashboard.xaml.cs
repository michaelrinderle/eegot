using eegot.ViewModels;
using System.Windows.Controls;

namespace eegot.Views
{
    public partial class Dashboard : Page
    {
        public DashboardViewModel vm { get; set; }
        public Dashboard()
        {
            InitializeComponent();
            this.DataContext = vm = new DashboardViewModel();
        }
    }
}
