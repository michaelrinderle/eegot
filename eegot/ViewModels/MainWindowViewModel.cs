using eegot.Commands;
using System.Windows.Input;

namespace eegot.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public ICommand QuitApplicationCommand
        {
            get => new RelayCommand(o => QuitApplication());
        }

        public ICommand ImportCommand
        {
            get => new RelayCommand(o => Import());
        }

        public MainWindowViewModel()
        {

        }

        private void QuitApplication() { }

        private void Import() { }
    }
}
