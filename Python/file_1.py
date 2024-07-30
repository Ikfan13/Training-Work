

# file_read=open('calculator.py','r')

# print(file_read.read())


import os
def createfile(filename):
      if(os.path.exists(filename)):
           print("File is Already exists")
      else:
           file_create= open(filename,'w')
def main():
    print("Enter the file name you want to create")
    file_name=input()

    createfile(file_name)
if __name__=="__main__":
    main()