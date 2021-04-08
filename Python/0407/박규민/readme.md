```Python
a = 13
if (a%2==0) :
    print("짝수")
else  :
    print("홀수")

Idnum = "881120-1068234"
print(Idnum[0:6])
print(Idnum[7:14])

Idnum = "881120-1068234"
if (Idnum[7]=="1") :
    print("남자입니다.")
else :
    print("여자입니다.")
	
	a= "a:b:c:d"
print(a.replace(":" , "#"))
```

```
남은 문제

score=[80,75,55]
result = (score[0]+score[1]+score[2])/len(score)
#score 리스트에 개수를 나타내는 함수 len
print(result)

list1 =[1,3,5,4,2]
print(list1)
list1.sort()
print(list1)
list1.reverse
print(list1)

join 사용안한 버전
lifels = ["life", "is", "too", "short"]
print(lifels) 
print(lifels[0]+" "+lifels[1]+" "+lifels[2]+" "+lifels[3])

join 사용버전
lifels= " ".join(["life", "is", "too", "short"])
print(lifels)

ad =[1,2,3]
ad.append(4)
print(ad)

a={'A':90,'B':80,'C':70}
print(a.pop('B'))
#print(a['B'])해도 됨

a=[1,1,1,2,2,3,3,3,4,4,5]
a=set(a)
print(a)

파이썬은 다음처럼 동일한 값에 여러 개의 변수를 선언할 수 있다. 
다음과 같이 a, b 변수를 선언한 후 a의 두 번째 요솟값을 변경하면 b 값은 어떻게 될까?
그리고 이런 결과가 오는 이유에 대해 설명해 보자.
a=b=[1,2,3]
a[1] =4
a[0] =5
print(b)

a,b는 리스트로써 같다고 정의를 했기 때문에 동일한 리스트를 가지고 있기 때문에 완전히 같다고 할 수 있다.
만약 다른 주소를 가르키도록 하고 싶다면 
첫번째 방법은
a=[1,2,3]
b=a[:]라고 정의하면 된다.

두번째 방법은
from copy import copy
b= copy(a)라고 정의하면 된다.
```

