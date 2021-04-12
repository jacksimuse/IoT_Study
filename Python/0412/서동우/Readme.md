https://wikidocs.net/42528

# Q1
주어진 자연수가 홀수인지 짝수인지 판별해 주는 함수(is_odd)를 작성해 보자.
```python
def is_odd (a):
   if (a%2 == 0):
      print('짝수입니다')
   else:
      print('홀수입니다')

a = int(input())  # 숫자 입력받음
is_odd(a)         # 입력받은 값을 함수에 전달
```


# Q2
입력으로 들어오는 모든 수의 평균 값을 계산해 주는 함수를 작성해 보자. 
(단 입력으로 들어오는 수의 개수는 정해져 있지 않다.)
```python
def avg_Num(a):
  result = 0
  for i in a:
    result += a[i-1]
  return(result/len(a))

input = list(map(int, input().split()))   # 1 2 3 4 5  식으로 숫자를 입력받았을때 각각 쪼개서 배열로 iuput에 저장
print(avg_Num(input))                     # 배열의 값들을 평균돌리는 함수에 전달
```

# Q3
다음은 두 개의 숫자를 입력받아 더하여 돌려주는 프로그램이다.

```python
input1 = input("첫번째 숫자를 입력하세요:")
input2 = input("두번째 숫자를 입력하세요:")

total = input1 + input2
print("두 수의 합은 %s 입니다" % total)
```
이 프로그램을 수행해 보자.

```
첫번째 숫자를 입력하세요:3
두번째 숫자를 입력하세요:6
두 수의 합은 36 입니다
```
3과 6을 입력했을 때 9가 아닌 36이라는 결괏값을 돌려주었다. 이 프로그램의 오류를 수정해 보자.

A)
```python
input1 = input("첫번째 숫자를 입력하세요:")
input2 = input("두번째 숫자를 입력하세요:")

total = int(input1) + int(input2)
print("두 수의 합은 %d 입니다" % total)
```
키보드로 입력받는 input을 int형으로 바꿔주어야함.

# Q6
사용자의 입력을 파일(test.txt)에 저장하는 프로그램을 작성해 보자. 
(단 프로그램을 다시 실행하더라도 기존에 작성한 내용을 유지하고 새로 입력한 내용을 추가해야 한다.)
```python
userInput = input("사용자 내용 : ")
f = open("test.txt", 'a')
f.write(userInput)
f.write("\n")
f.close()
```
(얜 이해가 잘 안됨.. 다음기회에)

-----------------------------------------------------
## 추가 문제
재밌는 풀 수 있을만한 문제를 찾았는데, 풀고 싶은 사람만 연습삼아 풀어보면 될 것 같습니당
https://programmers.co.kr/learn/courses/30/lessons/12916

대문자와 소문자가 섞여있는 문자열 s가 주어집니다. s에 'p'의 개수와 'y'의 개수를 비교해 같으면 True, 다르면 False를 return 하는 solution를 완성하세요. 'p', 'y' 모두 하나도 없는 경우는 항상 True를 리턴합니다. 단, 개수를 비교할 때 대문자와 소문자는 구별하지 않습니다.

예를 들어 s가 "pPoooyY"면 true를 return하고 "Pyy"라면 false를 return합니다.
