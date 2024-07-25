#write a program which will check the number is greater and equal to 70 and less than and equal to 90



def main():
    size=int(input("enter the size of your list"))
    lst=[]
    for i in range(size):
        value=int(input("Enter the Element"))
        lst.append(value)

    print(lst)
    
    filter_list=list(filter(lambda y:70>=y<=90,lst))
    print("Filter List is",filter_list)
    

if __name__=="__main__":
    main()