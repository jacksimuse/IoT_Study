origin_digit = input()
ten_p = int(origin_digit) // 10
one_p = int(origin_digit) % 10
new_digit = ten_p + one_p
count = 0
while int(origin_digit) != new_digit:
    new_digit = str(one_p) + str(new_digit)
    if int(new_digit) < 10:
        new_digit = '0' + str(new_digit)
    ten_p = int(new_digit) // 10
    one_p = int(new_digit) % 10
    new_digit = ten_p + one_p
    count += 1
    
print(new_digit)
print(count)