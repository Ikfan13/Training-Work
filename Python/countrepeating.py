def count(list,num):
    count=0
    for i in list:
       if (i==num):
          count=count+1

    print(f'{num} is repeating {count} times')  




def main():
  print('Enter the size of the list :')
  size=int(input())
  data=[]
  for i in range(size):
     print('Enter the element :')
     value=int(input())
     data.append(value)

  print(data)
  searched_num=int(input("Enter the number to be searched : "))
  count(data,searched_num)


if __name__=="__main__":
  main()
