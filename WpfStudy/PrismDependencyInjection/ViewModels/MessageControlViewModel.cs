using PrismDependencyInjection.Core;

namespace PrismDependencyInjection.ViewModels
{
    public class MessageControlViewModel : ViewModelBase
    {
        private string _message = string.Empty;
        /// <summary>
        /// 메시지
        /// </summary>
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }

        public MessageControlViewModel()
        {

        }

        public MessageControlViewModel(IContainerProvider containerProvider) : base(containerProvider)
        {
        }

        protected override void OnButtonClick(object obj)
        {
            if (obj is string str)
            {
                Message = MessageService.GetMessage(str);
            }
        }
    }
}
