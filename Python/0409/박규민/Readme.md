```Python
#Q1
num=0
a=0
while num<1000:
    num=num+1
    if num%3==0:
        a=a+num
print(a)

#Q2
a=0
while a<5 :
    a=a+1
    b=0
    while b<a:
        b=b+1
        print("*", end="")
    print(" ")
    
#Q3
for num in range(1,101) :
    print(num)
    
#Q4
A = [70,60,55,75,95,90,80,80,85,100]
sum =0
for i in A:
    sum=sum+i
print(sum/10)

#Q5
numbers = [1, 2, 3, 4, 5]
result = [n*2 for n in numbers if n % 2 ==1]
print(result)
