a = ['1', '2', '3']
a[2]='4'
del a[2]
a.append('3')
a.append('4')
a.append('9')
a.append('8')
a.append('7')
a.append('6')
a.sort()
a.reverse()
print(a.index('3'))

a.insert(1,100)
print(a.pop(1))
a.extend([1,23,4])
b=[4,666]
a.extend(b)
print(a)


t1=('1','2','3')
t2=t1*2
print(len(t2))


s1 = set([1,2,3])
print(s1)
# set안에 숫자랑 문자를 같이 넣는 방법?
s2 = set("print")
l1 = list(s2)
print(l1[0])
#list를 설정해주지 않으면 인덱스 사용 불가, 
#set함수는 중복 허용X, 순서가 없기 때문에
P1=s1&s2
P2=s1|s2
P3=s1-s2
print(P1)#교집합
print(P2)#합집합
print(P3)#차집합
#set 자료형에 값 추가
s2.add(1) # 한개의 값
s2.update([4,5,6]) # 여러개의 값
#set 자료형에 값 삭제
s2.remove('p')
s2.remove(4)
print(s2)
print(id(s2))#변수가 가리키는 메모리의 주소



#bool 형식
#"",[],{},() 괄호가 비어있을경우에는 false가 된다
#1은 참,0은 거짓

#[:] 이용
g = [1,2,3]
u = g[:]
g[1] =6
print(g)
print(u)

#copy 함수
from copy import copy
e = copy(g)
print(e)

a, b = ('python', 'life')#튜플의 경우에는 괄호생략해도 상관없음
print(a)
print(b)

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


lifels= " ".join(["life", "is", "too", "short"])
print(lifels)

ad =[1,2,3]
ad.append(4)
print(ad)

a = dict()
a[('name')] ='python'
a[('a',)] ='python'
#a[[1]] ='python' 대괄호 두개X
a[250] ='python'
print(a)

a={'A':90,'B':80,'C':70}
print(a.pop('B'))

a=[1,1,1,2,2,3,3,3,4,4,5]
a=set(a)
print(a)

a=b=[1,2,3]
a[1] =4
a[0] =5
print(b)