# 4월 9일 연습문제

## 03장 프로그램의 구조를 쌓는다! 제어문

https://wikidocs.net/42527

### Q1
다음 코드의 결괏값은 무엇일까?
```python
a = "Life is too short, you need python"

if "wife" in a: print("wife")
elif "python" in a and "you" not in a: print("python")
elif "shirt" not in a: print("shirt")
elif "need" in a: print("need")
else: print("none")
```

### Q2
while문을 사용해 1부터 1000까지의 자연수 중 3의 배수의 합을 구해 보자.

### Q3
while문을 사용하여 다음과 같이 별(*)을 표시하는 프로그램을 작성해 보자.
```python
*
**
***
****
*****
```

### Q4
for문을 사용해 1부터 100까지의 숫자를 출력해 보자.

### Q5
A 학급에 총 10명의 학생이 있다. 이 학생들의 중간고사 점수는 다음과 같다.

[70, 60, 55, 75, 95, 90, 80, 80, 85, 100]

for문을 사용하여 A 학급의 평균 점수를 구해 보자.

### Q6
리스트 중에서 홀수에만 2를 곱하여 저장하는 다음 코드가 있다.
```python
numbers = [1, 2, 3, 4, 5]
result = []
for n in numbers:
    if n % 2 == 1:
        result.append(n*2)
```

위 코드를 리스트 내포(list comprehension)를 사용하여 표현해 보자.