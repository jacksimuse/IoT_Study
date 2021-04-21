def solution(sentence):
    str = ''
    for c in sentence:
        if c != '.' or c != ' ':
            str += c
    size = len(str)
    for i in range(size // 2):
        if str[i] != str[size - 1 - i]:
            return False
    return True


#The following is code to output testcase. The code below is correct and you shall correct solution function.
sentence1 = "never odd or even."
ret1 = solution(sentence1)

#Press Run button to receive output.
print("Solution: return value of the function is", ret1, ".")
    
sentence2 = "palindrome"
ret2 = solution(sentence2)

#Press Run button to receive output.
print("Solution: return value of the function is", ret2, ".")