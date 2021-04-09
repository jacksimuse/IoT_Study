# Q1
```python
#다음 코드의 결괏값은 무엇일까?

a = "Life is too short, you need python"

if "wife" in a: print("wife")
elif "python" in a and "you" not in a: print("python")
elif "shirt" not in a: print("shirt")
elif "need" in a: print("need")
else: print("none")
```
### shirt 

# Q2
```python
# while문을 사용해 1부터 1000까지의 자연수 중 3의 배수의 합을 구해 보자.
b = 1
a = 0
while b<1000 :
  if(b%3==0):
     a= a+b
  b= b+1
  
print(a)
```

# Q3
```
# while문을 사용하여 다음과 같이 별(*)을 표시하는 프로그램을 작성해 보자.
*
**
***
****
*****
```

```python
a, b = 0, 0;
while(b<5):
  while(a>=0):
    print("*", end="")
    a=a-1
  print()
  b = b+1
  a = b;
```


# Q4
```python
#for문을 사용해 1부터 100까지의 숫자를 출력해 보자.
for i in range(1, 101): 
  print(i)
  ++i
```



# Q5

```python
# A 학급에 총 10명의 학생이 있다. 이 학생들의 중간고사 점수는 다음과 같다.
# [70, 60, 55, 75, 95, 90, 80, 80, 85, 100]
# for문을 사용하여 A 학급의 평균 점수를 구해 보자.
a = [70, 60, 55, 75, 95, 90, 80, 80, 85, 100]
result = 0
for i in a:
  result = result + i
print(result/len(a))
print()
```



# Q6
```python
# 리스트 중에서 홀수에만 2를 곱하여 저장하는 다음 코드가 있다.
numbers = [1, 2, 3, 4, 5]
result = []
for n in numbers:
    if n % 2 == 1:
        result.append(n*2)
# 위 코드를 리스트 내포(list comprehension)를 사용하여 표현해 보자.
```

```python
numbers = [1, 2, 3, 4, 5]
result = [n * 2 for n in numbers if n % 2 == 1]
print(result)
```




