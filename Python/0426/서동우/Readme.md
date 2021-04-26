## 백준 1110번 문제

```python
Input = int(input())
num = Input
count = 0

while True:
    ten = num // 10
    one = num % 10
    a = (ten + one) % 10
    num = (one * 10) + a

    count = count + 1
    if(num == Input):
        break
    
print(count)
```
