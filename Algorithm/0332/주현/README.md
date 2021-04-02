# 1. 사분면 고르기
```python
x = int(input())
y = int(input())
if (x>0 and y>0):
	print(1)
elif (x<0 and y>0):
	print(2)
elif (x<0 and y<0):
	print(3)
else:
	print(4)
```
각각 x와 y를 int형으로 입력받은 후, 양수 또는 음수에 따라 사분면을 나눠서 출력함

# 2. 윤년
```python
year = int(input())
if (year % 4 == 0 and (year % 100 != 0 or year % 400 == 0)):
	print(1)
else:
	print(0)
```
n의 배수라는 것은 n으로 나눴을 때 나머지가 0이라는 말과 같다
이것을 이용하여 if 조건문을 작성한다
