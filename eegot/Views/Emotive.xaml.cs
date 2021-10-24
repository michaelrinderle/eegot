using eegot.ViewModels;
using System.Windows.Controls;

namespace eegot.Views
{
    public partial class Emotive : Page
    {
        public EmotiveViewModel vm { get; set; }
        public Emotive()
        {
            InitializeComponent();
            this.DataContext = vm = new EmotiveViewModel();
        }
    }
}
