using PrismDependencyInjection.Services;
using System.Windows;
using PrismDependencyInjection.Views;

namespace PrismDependencyInjection
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // transient
            containerRegistry.Register<IDateTimeService, DateTimeService>();
            containerRegistry.Register<IMessageService, MessageService>();
        }

        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }
    }
}
