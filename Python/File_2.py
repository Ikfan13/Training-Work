#Comparision

import os
import filecmp
def filecomp(file1,file2):
          if(not(os.path.exists(file1))):
                print(f'{file1} is not existed')
          elif(not(os.path.exists(file2))):
                print(f'{file2} is not existed')
          else:
                compare=filecmp.cmp(file1,file2)
                if compare==True:
                      print("successfully compared")
                else:
                      print("Different Files")
        



def main():
    file1=input("Enter the file name 1")
    file2=input("Enter the file name 2")
    filecomp(file1,file2)

if __name__=="__main__":
    main()