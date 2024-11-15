using DotNetDependencyInjection.Services;
using System.Windows.Input;

namespace DotNetDependencyInjection.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IDateTimeService _dateTimeService;

        private string _dateTimeString = string.Empty;
        /// <summary>
        /// 시간 문자열
        /// </summary>
        public string DateTimeString
        {
            get => _dateTimeString;
            set => SetProperty(ref _dateTimeString, value);
        }

        /// <summary>
        /// Button Click Command
        /// </summary>
        public ICommand ButtonClickCommand { get; set; }

        public MainWindowViewModel()
        {

        }

        public MainWindowViewModel(IDateTimeService dateTimeService)
        {
            _dateTimeService = dateTimeService;
            ButtonClickCommand = new DelegateCommand(OnButtonClick);
        }

        /// <summary>
        /// Button Click Command Event
        /// </summary>
        private void OnButtonClick()
        {
            DateTimeString = _dateTimeService.GetDateTimeString();
        }
    }
}
