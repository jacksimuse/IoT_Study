```Python
# Q1

a = "Life is too short, you need python"

if "wife" in a : print("wife") # wife가 a에 있다면 wife출력
elif "python" in a and "you" not in a: print("python") # python이 a에 있고 you가 a에 없으면 python 출력
elif "shirt" not in a: print("shirt") # shirt가 a에 없으면 shirt 출력
elif "need" in a: print("need") # need가 a에 있으면 need 출력
else: print("none") # 위에꺼 다 아니면 none 출력
# 결과: shirt

# Q2
i = 0
a= 0 // 3의 배수들을 담을 그릇
while i < 1001: // i가 1001보다 작을동안 반복실행
  i = i + 1 // i 1씩 증가
  if i %  3 == 0: // 3의 배수
   a = + i // 3의 배수들이 그릇에 더해지는중
print(a)

# Q3
i = 0
while i < 6:
  i = i + 1
  print("*" * i) // i개수만큼 *이 찍힘
print(' ')// 다음 줄로 넘기기

# Q4
a = range(100)
for i in a:
  i = i + 1
  print(i)
  
# Q5
score = [70, 60, 55, 75, 95, 90, 80, 80, 85, 100]
sum = 0 // 각 요소들을 담을 그릇
for a in score:
  sum += a // 각 요소들이 그릇에 더해지는 중
average = sum / 10
print(average)

# Q6
numbers = [1, 2, 3, 4, 5]
result = [n * 2 for n in numbers if n % 2 == 1] 
print(result)
```
