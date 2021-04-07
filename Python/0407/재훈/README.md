```Python
# Q1
if 13 % 2 == 0:
    print("13은 짝수")
else:
    print("13은 홀수")

# Q2
resident_registration_number = "881120-1068234"
yyyymmdd = resident_registration_number[:6] // 881120
rest = resident_registration_number[7:] // 1068234
print(yyyymmdd)
print(rest)

# Q3
pin = "881120-1068234"
print(pin[7:8]) // 1

# Q4
a = "a:b:c:d"
b = a.replace(":", "#")
print(b) // a#b#c#d
```
