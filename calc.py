loop: bool = True
print("Enter a number")
calc = float(input())
while bool:
    print("Enter an operator")
    operator_input = input()
    if operator_input == "+":
        print("Enter a number")
        number = float(input())
        calc += number
    elif operator_input == '/':
        print("Enter a number")
        number = float(input())
        calc /= number
    elif operator_input == '*':
        print("Enter a number")
        number = float(input())
        calc *= number
    elif operator_input == '-':
        print("Enter a number")
        number = float(input())
        calc -= number
    elif operator_input == '=':
        print(calc)
        break
    else:
        print("Failed")

print("Enter anything to continue")
input()
