## Behavior

```c#
public class WebViewNavigateHtmlBehavior : Behavior<WebView2>
{
    protected override void OnAttached()
    {

    }

    protected override void OnDetaching()
    {

    }

    public string HtmlString
    {
        get => (string)GetValue(HtmlStringProperty);
        set => SetValue(HtmlStringProperty, value);
    }

    /// <summary>
    /// HtmlString
    /// </summary>
    public static readonly DependencyProperty HtmlStringProperty =
        DependencyProperty.Register(nameof(HtmlString), typeof(string), typeof(WebViewNavigateHtmlBehavior), new PropertyMetadata(null, HtmlStringChanged));

    private static void HtmlStringChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        var behavior = (WebViewNavigateHtmlBehavior)d;
        behavior.SetWebViewSource(e.NewValue as string);
    }

    /// <summary>
    /// 뷰모델에서 전달받은 Html을 WebView Source로 설정
    /// </summary>
    /// <param name="value"></param>
    private async void SetWebViewSource(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return;
        }
        await AssociatedObject.EnsureCoreWebView2Async();
        AssociatedObject.NavigateToString(value);
    }
}
```

```xaml
xmlns:b="http://schemas.microsoft.com/xaml/behaviors"
xmlns:wv2="clr-namespace:Microsoft.Web.WebView2.Wpf;assembly=Microsoft.Web.WebView2.Wpf"
...

<wv2:WebView2 Grid.Row="2" VerticalAlignment="Stretch">
    <b:Interaction.Behaviors>
        <wpfBehavior:WebViewNavigateHtmlBehavior HtmlString="{Binding TravelReviewInfo.내용}" />
    </b:Interaction.Behaviors>
</wv2:WebView2>
```
