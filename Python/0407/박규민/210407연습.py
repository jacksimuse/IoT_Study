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