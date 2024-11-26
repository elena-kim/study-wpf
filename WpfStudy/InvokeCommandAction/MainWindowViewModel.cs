using System.Windows.Input;

namespace InvokeCommandAction
{
    public class MainWindowViewModel : BindableBase
    {
        private const string DefaultErrorMsg = "입력값이 공백입니다.";

        private string _firstText;
        public string FirstText
        {
            get => _firstText;
            set => SetProperty(ref _firstText, value);
        }

        private string _secondText;
        public string SecondText
        {
            get => _secondText;
            set => SetProperty(ref _secondText, value);
        }

        private string _firstErrorMessage;
        public string FirstErrorMessage
        {
            get => _firstErrorMessage;
            set => SetProperty(ref _firstErrorMessage, value);
        }

        private string _secondErrorMessage;
        public string SecondErrorMessage
        {
            get => _secondErrorMessage;
            set => SetProperty(ref _secondErrorMessage, value);
        }

        public ICommand FirstTextChangedCommand { get; set; }
        public ICommand SecondTextChangedCommand { get; set; }

        public MainWindowViewModel()
        {
            FirstTextChangedCommand = new DelegateCommand(OnFirstTextChanged);
            SecondTextChangedCommand = new DelegateCommand<string>(OnSecondTextChanged);
            FirstErrorMessage = DefaultErrorMsg;
            SecondErrorMessage = DefaultErrorMsg;
        }

        private void OnFirstTextChanged()
        {
            FirstErrorMessage = string.IsNullOrEmpty(FirstText) ? DefaultErrorMsg : string.Empty;
        }

        private void OnSecondTextChanged(string name)
        {
            SecondErrorMessage = string.IsNullOrEmpty(name) ? DefaultErrorMsg : string.Empty;
        }
    }
}
