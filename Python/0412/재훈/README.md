```Python
# Q1
def is_odd(a):
  if a % 2 == 0:
      print("짝수")
  else:
    print("홀수")
#a = is_odd(4) 처럼 ()안에 숫자를 넣으면 판별가능
```
```Python
# Q2
def sum_average(*a): #매개변수가 여러개인 *표시
    sum = 0 # 총합
    result = 0 #평균그릇
    for i in a:
        sum += i
        result = sum / len(a)
    return result #계산한 것을 평균그릇에 담음

#print(sum_average(1, 2)) 함수안에 매개변수를 알아서 추가하면됨
```
```Python
# Q3
input1 = input("첫번째 숫자를 입력하세요:")
input2 = input("두번째 숫자를 입력하세요:")

total = int(input1) + int(input2) #int형으로 바꿔서 합하면 숫자로 합쳐짐 *parse 필요없음*
print("두 수의 합은 %s 입니다" % total)
```
```Python
# Q4
#먼저 만들기 실행
f = open("새파일.txt", 'w')
f.close()
# 글 추가 따로 실행
f = open("새파일.txt", 'a')
for i in range(1, 11):
    data = "%d번째 줄입니다 \n" % i
    f.write(data)
f.close
```
