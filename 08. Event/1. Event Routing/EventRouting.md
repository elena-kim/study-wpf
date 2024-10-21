## 이벤트 라우팅
이벤트 발생 시에 컨트롤의 하위 또는 상위로 전달되는 것. 여기서 하위 또는 상위는 Element Tree를 기준으로 한다.

이벤트 라우팅은 `버블링(Bubbling)`, `터널링(Tunneling)`, `다이렉트(Direct)` 이벤트로 분류할 수 있다.
<br/>
- 버블링(Bubbling): 이벤트 원본 요소에서 루트 요소(일반적으로 Page, Window)로 이벤트 발생
- 터널링(Tunneling): 루트 요소에서 원본 요소로 이벤트 발생
- 다이렉트(Direct): 원본 요소에서만 이벤트 발생

WPF의 이벤트 라우팅 모델은 자동으로 이벤트를 상위 객체로 라우팅 시킨다. (=> 버블링)

<br/>
<br/>

<img src="https://blog.kakaocdn.net/dn/S5yUl/btsKbjISQRN/fK2rjDTfpBQOS6DzkFguX1/img.png"/>

위 트리 그림에서 **leaf element #2**는 `PreviewMouseDown`, `MouseDown` 이벤트의 소스다.

<br/>

**leaf element #2**에서 마우스를 누른 후 이벤트 처리 순서는 아래와 같다.

1. Root element의 `PreviewMouseDown` 터널링 이벤트
2. intermediate element #1의 `PreviewMouseDown` 터널링 이벤트
3. leaf element #2의 `PreviewMouseDown` 터널링 이벤트
4. leaf element #2의 `MouseDown` 버블링 이벤트
5. intermediate element #1의 `MouseDown` 버블링 이벤트
6. Root element의 `MouseDown` 버블링 이벤트

<br/>

```csharp
public delegate void RoutedEventHandler(object sender, RoutedEventArgs e);
```

RoutedEventHandler 대리자는 이벤트를 발생시킨 객체와 이벤트 핸들러를 호출한 객체에 대한 정보를 제공한다.
<br/>
여기서 이벤트를 발생시킨 객체는 RoutedEventArgs의 `Source` 프로퍼티이고, 핸들러를 호출한 객체는 `sender` 파라미터이다.
<br/>

이벤트가 Element Tree에 통해 라우팅 되는 과정에서 이벤트를 발생시킨 객체인 `Source`는 변하지 않지만 `sender`는 계속 변하게 된다. 
위 다이어그램의 이벤트 처리 순서에서 3번과 4번은 `Source`와 `sender`가 동일한 객체이다.

 
<br/>
<br/>
💡 참고
<br/>
https://learn.microsoft.com/en-us/dotnet/desktop/wpf/events/routed-events-overview?view=netdesktop-7.0&redirectedfrom=MSDN 
