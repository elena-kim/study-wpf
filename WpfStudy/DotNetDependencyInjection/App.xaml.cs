using System.Windows;
using DotNetDependencyInjection.ViewModels;
using DotNetDependencyInjection.Services;
using DotNetDependencyInjection.Views;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetDependencyInjection
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; set; }

        /// <summary>
        /// OnStartup
        /// </summary>
        /// <param name="e"></param>
        protected override void OnStartup(StartupEventArgs e)
        {
            var services = ConfigureServices();
            ServiceProvider = services.BuildServiceProvider();

            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }

        /// <summary>
        /// Configure Services
        /// </summary>
        /// <returns></returns>
        private ServiceCollection ConfigureServices()
        {
            ServiceCollection serviceCollection = new();

            serviceCollection.AddTransient<IDateTimeService, DateTimeService>();
            serviceCollection.AddSingleton<MainWindowViewModel>();
            serviceCollection.AddSingleton(s => new MainWindow()
            {
                DataContext = s.GetRequiredService<MainWindowViewModel>()
            });

            return serviceCollection;
        }
    }

}
