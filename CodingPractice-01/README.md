# 코딩 연습 - 널(null) 다루기 (1)

`Program.cs`에 아래 과제들의 코드를 순서대로 작성하세요.
모든 과제를 작성한 후 실행하면 각 과제의 실행 결과가 순서대로 출력됩니다.

> 💡 변수 이름이 겹치는 경우 중괄호 `{ }`로 코드를 감싸면 각 블록에서 같은 이름을 사용할 수 있습니다.

---

## 1. null의 개념

정수형 변수 `number`에 0을, 문자열 변수 `text`에 빈 문자열 `""`을, 문자열 변수 `nothing`에 `null`을 저장하고 각각 `Console.WriteLine`으로 출력하세요.

**실행 결과**

```
0


```

---

## 2. 값 형식과 참조 형식의 null 처리

문자열 변수 `name`에 `null`을 할당하고, `name == null`의 결과를 출력하세요.

**실행 결과**

```
True
```

---

## 3. Nullable 형식

### 3-1. Nullable 형식 선언

`int?`, `double?`, `bool?` 타입의 변수를 각각 `null`로 선언하고, `Nullable<int>`, `Nullable<double>` 타입의 변수도 `null`로 선언한 뒤, `int?` 변수 3개를 `Console.WriteLine`으로 출력하세요.

**실행 결과**

```



```

### 3-2. HasValue와 Value 속성

`int?` 타입 변수 `score`를 `null`로 선언하고 `HasValue`를 출력하세요. 그 다음 `score`에 95를 할당하고 `HasValue`와 `Value`를 출력하세요.

**실행 결과**

```
score.HasValue: False
score.HasValue: True
score.Value: 95
```

### 3-3. HasValue 조건 분기

`int?` 타입 변수 `empty`를 `null`로 선언하고, `HasValue`가 true이면 `Value`를 출력하고, 아니면 "값이 없습니다."를 출력하세요.

**실행 결과**

```
값이 없습니다.
```

### 3-4. GetValueOrDefault 메서드

`int?` 타입 변수 `level`을 `null`로 선언하고, `GetValueOrDefault()`로 기본값을, `GetValueOrDefault(1)`로 커스텀 기본값을 출력하세요. 그 다음 `level`에 50을 할당하고 `GetValueOrDefault()`의 결과를 출력하세요.

**실행 결과**

```
기본값 사용: 0
커스텀 기본값: 1
값이 있을 때: 50
```

### 3-5. Nullable 형식의 변환

정수 `number`에 42를 저장하고, `int?` 변수 `nullable`에 암시적 변환으로 할당하세요. 다시 `int` 변수 `back`에 명시적 캐스팅 `(int)`으로 변환하여 할당하고, 두 값을 출력하세요.

**실행 결과**

```
nullable: 42
back: 42
```

---

## 4. 널 병합 연산자 (??)

### 4-1. 기본 사용법

문자열 변수 `message`를 `null`로 선언하고, `??` 연산자로 `"기본 메시지"`를 기본값으로 지정하여 `result`에 저장 후 출력하세요. 그 다음 `message`에 `"안녕하세요"`를 할당하고 같은 방식으로 출력하세요.

**실행 결과**

```
기본 메시지
안녕하세요
```

### 4-2. if문과의 비교

문자열 변수 `input`을 `null`로 선언하고, if문으로 null 체크하여 `output`에 `"기본값"`을 할당한 결과를 출력하세요. 같은 동작을 `??` 연산자로도 구현하여 출력하세요.

**실행 결과**

```
if문 결과: 기본값
?? 연산자 결과: 기본값
```

### 4-3. Nullable 값 형식과 함께 사용

`int?` 변수 `score`를 `null`로 선언하고, `?? -1`로 기본값을 지정하여 출력하세요. `int?` 변수 `health`도 `null`로 선언하고, `?? default(int)`로 기본값을 지정하여 출력하세요.

**실행 결과**

```
점수: -1
체력: 0
```

### 4-4. 연속 사용 (체이닝)

문자열 변수 `first`, `second`를 `null`로, `third`를 `"세 번째 값"`으로 선언하고, `first ?? second ?? third`의 결과를 출력하세요.

**실행 결과**

```
세 번째 값
```
