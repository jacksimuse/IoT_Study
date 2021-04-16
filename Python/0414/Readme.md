# Q1

다음은 Calculator 클래스이다.
```python
class Calculator:
    def __init__(self):
        self.value = 0

    def add(self, val):
        self.value += val
```
위 클래스를 상속하는 UpgradeCalculator를 만들고 값을 뺄 수 있는 minus 메서드를 추가해 보자. 즉 다음과 같이 동작하는 클래스를 만들어야 한다.
```python
cal = UpgradeCalculator()
cal.add(10)
cal.minus(7)

print(cal.value) # 10에서 7을 뺀 3을 출력
```


```python
# Q1 내맘대로 풀이
class Calculator:
    def __init__(self):
        self.value = 0

    def add(self, first, second):
        return (first+second)

class UpgradeCalculator(Calculator):
  def minus(self, first, second):
     return (first-second)

cal = Calculator()
cal22222 = UpgradeCalculator()
print(cal.add(10, 10))

print(cal22222.minus(10, 10)) 
print(cal22222.add(10, 20))
```

<br>

```python
# Q1 저자식 풀이?
class Calculator:
    def __init__(self):
        self.value = 0

    def setdata(self, first, second):
      self.first = first
      self.second = second

    def add(self):
        return (self.first + self.second)

class UpgradeCalculator(Calculator):
  def minus(self):
     return (self.first - self.second)

# 부모 클래스 사용
cal = Calculator()
cal.setdata(10, 5)
print(cal.add())

# 자식 클래스 사용(어자피 상속됬으니까 add도 해봄)
cal22222 = UpgradeCalculator()
cal22222.setdata(20, 30)
print(cal22222.minus())
print(cal22222.add())
```



# Q2
객체변수 value가 100 이상의 값은 가질 수 없도록 제한하는 MaxLimitCalculator 클래스를 만들어 보자. 즉 다음과 같이 동작해야 한다.
```python
cal = MaxLimitCalculator()
cal.add(50) # 50 더하기
cal.add(60) # 60 더하기

print(cal.value) # 100 출력
```
단 반드시 다음과 같은 Calculator 클래스를 상속해서 만들어야 한다.
```python
class Calculator:
    def __init__(self):
        self.value = 0

    def add(self, val):
        self.value += val
```

```python
class Calculator:
    def __init__(self):
        self.value = 0

    def setdata(self, first, second):
      self.first = first
      self.second = second

    def add(self):
        return (self.first + self.second)

class MaxLimitCalculator(Calculator):
  def add(self):
    result = self.first + self.second
    if(result > 100):
        result = 100
        return result

cal = MaxLimitCalculator()   
cal.setdata(50,60)  
print(cal.add())
```



# Q4
filter와 lambda를 사용하여 리스트 [1, -2, 3, -5, 8, -3]에서 음수를 모두 제거해 보자.
```python
a = [1, -2, 3, -5, 8, -3]
print(list(filter(lambda x:x>0, a)))
```


# Q7
다음 리스트의 최댓값과 최솟값의 합을 구해 보자.
```
[-8, 2, 7, 5, -3, 5, 0, 1]
```

```python
a = [-8, 2, 7, 5, -3, 5, 0, 1]
print(max(a), min(a))  # 최대, 최소값 출력
print(max(a) + min(a)) # (최대값 + 최소값) 출력
```



# Q8
17 / 3의 결과는 다음과 같다.
```
>>> 17 / 3
5.666666666666667
```
위와 같은 결괏값 5.666666666666667을 소숫점 4자리까지만 반올림하여 표시해 보자.

```python
a = 17 / 3
print(round(a, 4))
```

