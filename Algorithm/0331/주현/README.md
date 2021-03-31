# 1. 곱셈
```python
a = int(input())
b = input()
print(a*int(b[2]))
print(a*int(b[1]))
print(a*int(b[0]))
print(a*int(b))
```
b의 자리수별로 곱셈을 해야하므로 
b를 배열로 받아 각 자리수를 int형으로 바꾸어 곱셈을 했음
마지막에는 b자체를 int형으로 바꿔 최종 곱셈 결과를 냈음

# 2. 나눗셈
```python
a, b, c = input().split(" ")
a = int(a)
b = int(b)
c = int(c)
print((a+b)%c)
print(((a%c)+(b%c))%c)
print((a*b)%c)
print(((a%c)*(b%c))%c)
```
a, b, c 를 각각 입력받아 각각 int형으로 변환해줌
각 계산 결과를 출력함 .. 괄호에 유의..
