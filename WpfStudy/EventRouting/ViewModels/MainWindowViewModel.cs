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
            get => _isTunnelingTest;
            set => SetProperty(ref _isTunnelingTest, value, OnIsTunnelingTestChanged);
        }

        private string _testTitle = "Bubbling";
        /// <summary>
        /// 테스트 제목
        /// </summary>
        public string TestTitle
        {
            get => _testTitle;
            set => SetProperty(ref _testTitle, value);
        }

        /// <summary>
        /// MouseDown 커맨드
        /// </summary>
        public ICommand MouseDownCommand { get; set; }
        /// <summary>
        /// PreviewMouseDown 커맨드
        /// </summary>
        public ICommand PreviewMouseDownCommand { get; set; }

        public MainWindowViewModel() 
        {
            MouseDownCommand = new DelegateCommand<string>(OnMouseDown, (str) => !IsTunnelingTest).ObservesProperty(() => IsTunnelingTest);
            PreviewMouseDownCommand = new DelegateCommand<string>(OnPreviewMouseDown, (str) => IsTunnelingTest).ObservesProperty(() => IsTunnelingTest);
        }

        /// <summary>
        /// 터널링 테스트 여부 변경 이벤트
        /// </summary>
        private void OnIsTunnelingTestChanged()
        {
            TestTitle = _isTunnelingTest ? "Tunneling" : "Bubbling";
        }

        /// <summary>
        /// MouseDown Event
        /// </summary>
        public void OnMouseDown(string str)
        {
            MessageBox.Show($"{str} Mouse Down");
        }

        /// <summary>
        /// Preview MouseDown Event
        /// </summary>
        private void OnPreviewMouseDown(string str)
        {
            MessageBox.Show($"{str} Preview Mouse Down");
        }
    }
}
