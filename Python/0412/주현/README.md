```python
# Q1
def is_odd(num):
    if num % 2 == 0:
        return "짝수입니다."
    elif num % 2 == 1:
        return "홀수입니다"
    else:
        return "숫자가 아닙니다"
print(is_odd(5)) # 홀수입니다
print(is_odd(50)) # 짝수입니다


# Q2
def calc_mean(*args):
    sum = 0
    for a in args:
        sum = sum + a # 합계 구하기
    return sum / len(args) 
print(calc_mean(2, 2, 2, 4, 4, 4)) # 3.0


# Q3
input1 = input("첫번째 숫자를 입력하세요:")
input2 = input("두번째 숫자를 입력하세요:")

total = int(input1) + int(input2) # 입력 자료형은 문자열이므로 숫자형으로 자료형을 변환시켜줘야한당
print("두 수의 합은 %s 입니다" % total)


# Q6
f = open("4장/test1.txt", "a")
while True:
    a = input("작성할 내용을 입력하세요 : ")
    if a == "":
        break
    else:
        f.write(a + '\n')
f.close()
```

------------------------------------
### 추가문제
```python
def solution(s):
    ss = s.lower()  # 대소문자 구분을 없애기 위해서 모두 소문자로 변환
    pnum = 0  # p 개수를 셀 변수
    ynum = 0  # y 개수를 셀 변수
    
    for i in ss:  # 소문자로 변환된 문자열을 반복
        if i == 'p':  
            pnum = pnum + 1  # p가 있으면 pnum에 1을 더해서 개수 표시
        elif i == 'y':
            ynum = ynum + 1  # y가 있으면 ynum에 1을 더해서 개수 표시
    
    if pnum == ynum:
        return True
    elif pnum != ynum:
        return False
    else:
        return True
```
