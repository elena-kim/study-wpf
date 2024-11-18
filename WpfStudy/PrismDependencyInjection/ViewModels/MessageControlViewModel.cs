using PrismDependencyInjection.Services;
using System.Windows.Input;

namespace PrismDependencyInjection.ViewModels
{
    public class MessageControlViewModel : BindableBase
    {
        private readonly IMessageService _messageService;

        private string _message = string.Empty;
        /// <summary>
        /// 메시지
        /// </summary>
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }

        /// <summary>
        /// Button Click Command
        /// </summary>
        public ICommand ButtonClickCommand { get; set; }

        public MessageControlViewModel()
        {

        }

        public MessageControlViewModel(IMessageService messageService)
        {
            _messageService = messageService;
            ButtonClickCommand = new DelegateCommand<string>(OnButtonClick);
        }

        private void OnButtonClick(string str)
        {
            Message = _messageService.GetMessage(str);
        }
    }
}
