using PrismDependencyInjection.Core;

namespace PrismDependencyInjection.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
        }

        public MainWindowViewModel(IContainerProvider containerProvider) : base(containerProvider)
        {
        }
    }
}
