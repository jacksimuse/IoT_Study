money = True
if money :
    print("택시를 타고 간다")
else:
    print("걸어서 집에 간다")

#들여쓰기 잘해야됨
money = True
if money :
    print("택시를 ")
    print("타고")
    print("간다")

money=3000
if money>=4000 :
    print("택시를 타거라")
else:
    print("걸어가거라")
    
money=3000
card = True
if money>=4000 or card :
    print("택시를 타거라")
else:
    print("걸어가거라")

money=4000
card = True
if money>=4000 and card :
    print("택시를 타거라")
else:
    print("걸어가거라")

x=[1,2,3]
if 1 in x :
    print("x안에 1이 있넹")
else :
    print("x안에 1이 없네")

myPocket = ["cash","cellphone","wallet"]
if "cash" not in myPocket :
    print("돈없어 걸어가")
elif "cellphone" not in myPocket :
    print("핸드폰없다 빨리 찾으러 가라")
elif "wallet" not in myPocket:
    print("지갑없는데 뭐하냐 빨리 찾아라")
else :
    print("다 있냐? 그럼 빨리 집가자")
    

time = "5"
if(time==5):
    pass
else:
    print("공부안하고 뭐하냐")

score=70
if score >= 60:
    message = "success"
else:
    message = "failure"

treehit = 0
while treehit<10:
    treehit=treehit+1
    print("나무를 %d번을 찍었습니다" %treehit)
    if treehit==10 :
        print("나무가 넘어갑니다")

prompt = """
1. Add
2. Del
3. List
4. Quit

Enter number: """


number = 0
while number != 4:
    print(prompt)
    number = int(input())


coffee =100
money =300
while money:
    money=money+10
    coffee=coffee-1
    print("남은 양의 커피는 %d입니다" %coffee)
    if coffee==0:
        print(money)
        print("오늘 마감입니다.")
        break

coffee =2

while True:
    money = int(input("돈을 넣어주세요:"))
    if money==300:
        print("커피 가져가세요")
        coffee=coffee-1
    elif money>=300:
        print("거스름돈 %d입니다. 커피가져가세요" %(money-300))
        coffee=coffee-1
    else:
        print("커피를 주지 않습니다.")
    
    if coffee == 0 :
        print("오늘 장사는 마감하겠습니다")
        break

a=0
while a<10:
    a=a+1
    if a%2==1 :
        print(a)

a=0
while a<10:
    a=a+1
    if a%2==1 : continue
    print(a)

test_list =['one','two','three']
for i in test_list:
    print(i)

a = [(1,2),(3,4),(5,6)]
for (first,last) in a:
    print(first+last)


marks = [90,80,30,70,40]
number = 0
for mark in marks:
    number=number+1
    if mark>60 :
        print("%d번 학생은 합격입니다." %number)
    else:
        print("%d번 학생은 불합격입니다." %number)

marks = [90,80,30,70,40]
number = 0
for mark in marks:
    number=number+1
    if mark<60 : continue
    print("%d번 학생은 합격입니다." %number)
    
for i in range(2,10):
    for j in range(1,10):
        print(i*j, end=" ")
    print('')










