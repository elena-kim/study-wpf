## WPF 31 Tips

### 1. Project
프로젝트 시작은 닷넷코어로!
닷넷 개발에는 누겟패키지가 관여를 많이 하고 있음.
닷넷코어 자체가 오픈소스이다보니 업데이트 속도도 빠름.
CommunityToolkit, Prism 라이브러리들도 모두 닷넷코어쪽으로 발전하고 있음.

### 2. Reference
닷넷코어와 닷넷프레임워크의 Reference에 차이가 있음.
- 닷넷프레임워크 : **PresentationCore, PresentationFramework, System.xaml, WindowBase** 기본 참조들
- 닷넷코어: 프로젝트 더블 클릭하면 바로 속성 창. **TargetFramework** -windows가 왜 붙었을까? wpf와 윈폼은 윈도우에서 돌아가게 해줘라고 명시한 것, **UseWPF**. <br>
둘 중 하나만 없어도 wpf가 제대로 동작하지 않고 프레임워크쪽에 참조도 바로 날라감.

### 3. Application
프로젝트 생성 시 자동 추가 : App.xaml, MainWindow

```csharp
public class App : Application
{

}

override OnStartup
```

### 4. Window
프로젝트 > 사용자 정의 라이브러리(UserControl Library)
xaml에서 f12누르면 정의로 이동 가능 (x:class 등 경로가 나와있는경우)

### 5. StackPanel
템플릿 내보내기 : Visual Studio 2022 디렉토리 하위에 템플릿이 압축 저장, 지정한 템플릿의 버전을 자동으로 따라감.

### 6. Grid
기본으로 Width, Height는 Stretch 적용
그리드는 포토샵의 Layer처럼 계속 위로 겹쳐지는 형태

### 7. IsHitTestVisible
```xaml
<Grid>
    <Button Content="Click" />
    <Border Background="Green" Opacity="0.5" IsHitTestVisible="False"/>
</Grid>
```
IsHitTestVisible이 True이면 Border가 Button 위에 겹쳐진 형태이기 때문에 버튼 클릭이 안됨. 하지만 False로 지정하면 백그라운드는 유지한채 버튼 클릭이 가능해짐.

### 8. Border
Background, BorderBrush, CornerRadius

### 9. UniformGrid

### 10. Visibility

### 11. Opacity

### 12. Transparent + Color
투명도를 주었을때 글자색은 또렷하게 그대로 나오고 색상만 투명하게 하고 싶으면?
Background="#44000000" hex값 기본6자리 앞에 투명도를 지정해주기
투명도를 안할거면(기본 ff) 원래대로 6자리만 써주기~

### 13. Geometry
Pictogrammers (Material Design Icons)
> ViewBox로 아이콘 크기 설정하는거랑 Path에 RenderTransform Scale 키우는거랑 다른지?

### 14. DataContext
DataContext는 FrameworkElement 레벨이기 때문에 거의 모든 컨트롤들이 다 가지고 있음.
가장 가까운 DataContext가 적용됨. 

### 15. Binding

### 16. ViewModel

### 17. ElementName Binding

### 18. RelativeSource Binding
RelativeSource Self: 자기자신

### 19. Static Binding

### 20. IValueConverter

### 21. Resources
