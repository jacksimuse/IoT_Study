# # Q1
# class Calculator:
#     def __init__(self):
#         self.value = 0
#     def add(self, val):
#         self.value += val

# class UpgradeCalculator(Calculator): # Calculator 상속하고 minus 추가
#     def minus(self, val):
#         self.value -= val

# cal = UpgradeCalculator()
# cal.add(10)
# cal.minus(7)

# print(cal.value)

# Q2
class Calculator:
    def __init__(self):
        self.value = 0
    def add(self, val):
        self.value += val

class MaxLimitCalculator(Calculator):
    def add(self, val):
        self.value += val
        if self.value > 100:
            self.value = 100
            return self.value

cal = MaxLimitCalculator()
cal.add(50)
cal.add(60)
print(cal.value)

# Q3
print(list(filter(lambda x: x >0, [1, -2, 3, -5, 8, -3])))

# Q4
a = max([-8, 2, 7, 5, -3, 5, 0, 1])
b = min([-8, 2, 7, 5, -3, 5, 0, 1])

print(a + b)

# Q5
a = round((17/3), 4)
print(a)
