try:
    items=["Bread","Butter","Jam","Cheese"]
    # items[len(items)]="Milk"
    num=int(input("Enter a Number:"))
    assert num%2==0
    # num1=int(input("Enter the 1st number:"))
    # num2=int(input("Enter the 2nd number:"))

    # result=num1/num2

    # print(result)
except ZeroDivisionError:
    print("Denominator should not be zero")
except ValueError:
    print("Only numbers are allowed")
except IndexError:
    print("Array Index out of bound")
except AssertionError:
    print("Entered value is not matching")
else:
    print(num,"Is a even number")