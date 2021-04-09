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
while i < 1001:
  i = i + 1
  if i %  3 == 0:
   a = + i
print(a)

# Q3
i = 0
while i < 6:
  i = i + 1
  print("*" * i)
print(' ')

# Q4
a = range(100)
for i in a:
  i = i + 1
  print(i)
  
# Q5
score = [70, 60, 55, 75, 95, 90, 80, 80, 85, 100]
sum = 0
for a in score:
  sum += a
average = sum / 10
print(sum)
print(average)

# Q6
numbers = [1, 2, 3, 4, 5]
result = [n * 2 for n in numbers if n % 2 == 1]
print(result)
```