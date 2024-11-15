using PrismDependencyInjection.Core;

namespace PrismDependencyInjection.ViewModels
{
    public class DateTimeControlViewModel : ViewModelBase
    {
        private string _dateTimeString = string.Empty;
        /// <summary>
        /// 시간 문자열
        /// </summary>
        public string DateTimeString
        {
            get => _dateTimeString;
            set => SetProperty(ref _dateTimeString, value);
        }

        public DateTimeControlViewModel()
        {

        }

        public DateTimeControlViewModel(IContainerProvider containerProvider) : base(containerProvider)
        {
        }

        /// <summary>
        /// Button Click Command Event
        /// </summary>
        protected override void OnButtonClick(object _)
        {
            DateTimeString = DateTimeService.GetDateTimeString();
        }
    }
}
