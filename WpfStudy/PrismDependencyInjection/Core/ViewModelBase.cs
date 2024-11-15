using PrismDependencyInjection.Services;
using System.Windows.Input;

namespace PrismDependencyInjection.Core
{
    public class ViewModelBase : BindableBase, IViewModelBase
    {
        /// <summary>
        /// IoC Container
        /// </summary>
        protected IContainerProvider Container { get; }
        /// <summary>
        /// DateTime Service
        /// </summary>
        protected IDateTimeService DateTimeService { get; }
        /// <summary>
        /// Message Service
        /// </summary>
        protected IMessageService MessageService { get; }
        /// <summary>
        /// Button Click Command
        /// </summary>
        public ICommand ButtonClickCommand { get; set; }

        public ViewModelBase()
        {

        }

        public ViewModelBase(IContainerProvider containerProvider)
        {
            Container = containerProvider;
            DateTimeService = Container.Resolve<IDateTimeService>();
            MessageService = Container.Resolve<IMessageService>();

            ButtonClickCommand = new DelegateCommand<object>(OnButtonClick);
        }

        /// <summary>
        /// Button Click Command Event
        /// </summary>
        /// <param name="obj"></param>
        protected virtual void OnButtonClick(object obj)
        {
            
        }
    }
}
