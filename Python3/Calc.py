iNum1 = 0
bOK = False
cOpe = ""
iOpe = -1
iNum2 = 0
fAnswer = 0.0

#number 1
print("Input number 1: ", end="")   #end=""で改行なし
iNum1 = int(input())

#operator
print("Input arithmetic operator: ", end="")

while bOK == False:
    
    cOpe = input()

    if cOpe == "+":
        iOpe = 0
        bOK = True
    elif cOpe == "-":
        iOpe = 1
        bOK = True
    elif cOpe == "*":
        iOpe = 2
        bOK = True
    elif cOpe == "/":
        iOpe = 3
        bOK = True

#number 2
print("Input number 2: ", end="")
iNum2 = int(input())

if iOpe == 0:
    fAnswer = float(iNum1) + float(iNum2)
elif iOpe == 1:
    fAnswer = float(iNum1) - float(iNum2)
elif iOpe == 2:
    fAnswer = float(iNum1) * float(iNum2)
elif iOpe == 3:
    if iNum2 != 0:
        fAnswer = float(iNum1) / float(iNum2)
    else:
        fAnswer = -1
else:
    fAnswer = -1

print("Answer: ", fAnswer)  #改行あり
