import os
import filecmp

def createfile(filename):
      if(os.path.exists(filename)):
           print("File is Already exists")
      else:
           file_create=open(filename,'w')
           return file_create
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
        
def copy(file1,file2):
     pastefile=createfile(file2)
     copy_file=open(file1,'r')

     pastefile.write(copy_file.read())

     filecomp(pastefile,copy_file)
     
     


def main():
    file1=input("Enter the file name 1")
    file2=input("Enter thr file name 2")
    copy(file1,file2)

if __name__=="__main__":
    main()