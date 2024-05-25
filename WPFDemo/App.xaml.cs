using System.Windows;
using WPFDemo.IoC;
using WPFDemo.Stores;
using WPFDemo.ViewModels;
using WPFDemo.Views;

namespace WPFDemo
{
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            ServiceProviderExtensions.ConfigureServices();

            NavigationStore navigationStore = new();
            navigationStore.CurrentViewModel = new StartViewModel(navigationStore);

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(navigationStore)
            };

            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
