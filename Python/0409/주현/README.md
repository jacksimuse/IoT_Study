```python
# 1
a = "Life is too short, you need python"
if "wife" in a: print("wife")
elif "python" in a and "you" not in a: print("python")
elif "shirt" not in a: print("shirt")
elif "need" in a: print("need")
else: print("none")
# 출력 : shirt

# 2
number = 0
sum = 0
while number < 1000:
    number += 1
    if number % 3 == 0:
        sum += number
print(sum)

# 3
number = 0
line = 0
while line < 5:
    number += 1
    line += 1
    print("*" * number)

# 4
for i in range(1,101):
    print(i)

# 5
scores = [70, 60, 55, 75, 95, 90, 80, 80, 85, 100]
sum = 0
for score in scores:
    sum += score
print(f"평균 : {sum/len(scores)}")

# 6
numbers = [1, 2, 3, 4, 5]
result = []
# for n in numbers:
#     if n % 2 == 1:
#         result.append(n*2)
result = [n * 2 for n in numbers if n % 2 == 1]
print(result)
```