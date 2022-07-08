### Command

- ObservesProperty
- ObservesCanExecute 

### PrismCommandSample.sln

#### MainWindow.xaml
```xaml
<Window x:Class="PrismCommandSample.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800">
    <Grid>
        <StackPanel>
            <TextBox
                Width="100"
                Text="{Binding InputText, UpdateSourceTrigger=PropertyChanged}"/>
            <Button 
                Content="Click"
                Width="70"
                Height="30"
                Command="{Binding ClickCommand}"/>
        </StackPanel>
    </Grid>
</Window>
```

#### MainViewModel.cs
```csharp
using Prism.Commands;
using Prism.Mvvm;
using System.Windows.Input;

namespace PrismCommandSample
{
    public class MainViewModel : BindableBase
    {
        private string _inputText;
        public string InputText
        {
            get { return _inputText; }
            set { SetProperty(ref _inputText, value); }
        }

        public ICommand ClickCommand { get; set; }

        public MainViewModel()
        {
            ClickCommand = new DelegateCommand(
                () => OnClick(), () => !string.IsNullOrEmpty(InputText))
                .ObservesProperty(() => InputText);
        }

        private void OnClick()
        {
            //
        }
    }
}
```
`!string.IsNullOrEmpty(InputText)` 조건이 맞으면 `OnClick()` 실행됨.  
`InputText` 속성 변경을 체크해서 **`DelegateCommandBase.RaiseCanExecutechanged`** 를 호출함.
