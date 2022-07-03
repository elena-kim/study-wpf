## AttachedProperty

Attached Properties는 DP의 특수한 형태로 프로퍼티가 선언된 곳과 다른 곳에서 쓰일 수 있도록 하는 장치다. 

Panel.ZIndex 또는 Grid.Row와 같은 프로퍼티는 Button이나 TextBox 같은 컨트롤에서 쓰일 수 있지만 실제 프로퍼티의 정의는 Panel이나 Grid에 되어 있다. 즉 다른 인스턴스에 'attached'되는 것이다. 

DP와 다르게 static 메서드 형태로 Get / Set 을 정의하는데, 이는 다른 인스턴스에서 호출되어야 하기 때문이다.

> [Grid의 Column과 Row](https://github.com/dotnet/wpf/blob/main/src/Microsoft.DotNet.Wpf/src/PresentationFramework/System/Windows/Controls/Grid.cs)

```csharp
[CommonDependencyProperty]
public static readonly DependencyProperty ColumnProperty =
        DependencyProperty.RegisterAttached(
              "Column",
              typeof(int),
              typeof(Grid),
              new FrameworkPropertyMetadata(
                      0,
                      new PropertyChangedCallback(OnCellAttachedPropertyChanged)),
              new ValidateValueCallback(IsIntValueNotNegative));

[CommonDependencyProperty]
public static readonly DependencyProperty RowProperty =
        DependencyProperty.RegisterAttached(
              "Row",
              typeof(int),
              typeof(Grid),
              new FrameworkPropertyMetadata(
                      0,
                      new PropertyChangedCallback(OnCellAttachedPropertyChanged)),
              new ValidateValueCallback(IsIntValueNotNegative));
```

<br>

> Example
```csharp
public class Aquarium : UIElement
{
    // Register an attached dependency property with the specified
    // property name, property type, owner type, and property metadata.
    public static readonly DependencyProperty HasFishProperty =
        DependencyProperty.RegisterAttached(
          "HasFish",
          typeof(bool),
          typeof(Aquarium),
          new FrameworkPropertyMetadata(defaultValue: false,
              flags: FrameworkPropertyMetadataOptions.AffectsRender)
        );

    // Declare a get accessor method.
    public static bool GetHasFish(UIElement target) =>
        (bool)target.GetValue(HasFishProperty);

    // Declare a set accessor method.
    public static void SetHasFish(UIElement target, bool value) =>
        target.SetValue(HasFishProperty, value);
}
```
