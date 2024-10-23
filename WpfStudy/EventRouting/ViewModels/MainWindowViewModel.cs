using System.Windows;
using System.Windows.Input;

namespace EventRouting.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private bool _isTunnelingTest;
        /// <summary>
        /// 터널링 테스트 여부
        /// </summary>
        /// <remarks>true: 터널링 테스트, false: 버블링 테스트</remarks>
        public bool IsTunnelingTest
        {
            get { return _isTunnelingTest; }
            set { SetProperty(ref _isTunnelingTest, value, OnPropertyChanged); }
        }

        private void OnPropertyChanged()
        {
            TestTitle = _isTunnelingTest ? "Tunneling" : "Bubbling";
        }

        private string _testTitle = "Bubbling";
        /// <summary>
        /// 테스트 제목
        /// </summary>
        public string TestTitle
        {
            get { return _testTitle; }
            set { SetProperty(ref _testTitle, value); }
        }

        /// <summary>
        /// Label MouseDown 커맨드
        /// </summary>
        public ICommand LabelMouseDownCommand { get; set; }
        /// <summary>
        /// Grid MouseDown 커맨드
        /// </summary>
        public ICommand GridMouseDownCommand { get; set; }
        /// <summary>
        /// Border MouseDown 커맨드
        /// </summary>
        public ICommand BorderMouseDownCommand { get; set; }
        /// <summary>
        /// Label PreivewMouseDown 커맨드
        /// </summary>
        public ICommand LabelPreviewMouseDownCommand { get; set; }
        /// <summary>
        /// Grid PreivewMouseDown 커맨드
        /// </summary>
        public ICommand GridPreviewMouseDownCommand { get; set; }
        /// <summary>
        /// Border PreivewMouseDown 커맨드
        /// </summary>
        public ICommand BorderPreviewMouseDownCommand { get; set; }

        public MainWindowViewModel() 
        {
            //MouseDown
            LabelMouseDownCommand = new DelegateCommand(OnLabelMouseDown, () => !IsTunnelingTest).ObservesProperty(() => IsTunnelingTest);
            GridMouseDownCommand = new DelegateCommand(OnGridMouseDown, () => !IsTunnelingTest).ObservesProperty(() => IsTunnelingTest);
            BorderMouseDownCommand = new DelegateCommand(OnBorderMouseDown, () => !IsTunnelingTest).ObservesProperty(() => IsTunnelingTest);
            //PreviewMouseDown
            LabelPreviewMouseDownCommand = new DelegateCommand(OnLabelPreviewMouseDown, () => IsTunnelingTest).ObservesProperty(() => IsTunnelingTest);
            GridPreviewMouseDownCommand = new DelegateCommand(OnGridPreivewMouseDown, () => IsTunnelingTest).ObservesProperty(() => IsTunnelingTest);
            BorderPreviewMouseDownCommand = new DelegateCommand(OnBorderPreivewMouseDown, () => IsTunnelingTest).ObservesProperty(() => IsTunnelingTest);
        }

        /// <summary>
        /// Label MouseDown Event
        /// </summary>
        public void OnLabelMouseDown()
        {
            MessageBox.Show("Label Mouse Down");
        }

        /// <summary>
        /// Grid MouseDown Event
        /// </summary>
        public void OnGridMouseDown()
        {
            MessageBox.Show("Grid Mouse Down");
        }

        /// <summary>
        /// Border MouseDown Event
        /// </summary>
        public void OnBorderMouseDown()
        {
            MessageBox.Show("Border Mouse Down");
        }

        /// <summary>
        /// Label Preview MouseDown Event
        /// </summary>
        private void OnLabelPreviewMouseDown()
        {
            MessageBox.Show("Label Preview Mouse Down");
        }

        /// <summary>
        /// Grid PreivewMouseDown Event
        /// </summary>
        private void OnGridPreivewMouseDown()
        {
            MessageBox.Show("Grid Preview Mouse Down");
        }

        /// <summary>
        /// Border PreivewMouseDown Event
        /// </summary>
        private void OnBorderPreivewMouseDown()
        {
            MessageBox.Show("Border Preview Mouse Down");
        }
    }
}
