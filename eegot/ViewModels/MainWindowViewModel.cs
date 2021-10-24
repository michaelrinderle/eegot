using eegot.Commands;
using eegot.Models;
using System.Windows;
using System.Windows.Input;

namespace eegot.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public static ImportSubject ImportSubject {get;set;}

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
            ImportSubject = new ImportSubject();
        }

        public static void QuitApplication() 
        {
            string messageBoxText = "are you sure you want to exit?";
            string caption = "eegot";
            MessageBoxButton button = MessageBoxButton.YesNo;
            MessageBoxImage icon = MessageBoxImage.Warning;
            MessageBoxResult result;

            result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
            if(result == MessageBoxResult.Yes)
                System.Windows.Application.Current.Shutdown();
        }

        public void Import() 
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.DefaultExt = ".txt"; // Default file extension
            bool? result = dialog.ShowDialog();
            if (result == true)
            {
                ImportSubject.Path = dialog.FileName;
                ImportSubject.Notify();
            }
        }
    }
}
