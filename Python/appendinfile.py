def main():
 file=input("Enter the filename to append")
 append_file=open(file,'a')
 append_file.write("I am Mohamed Ikfan")
 read_file=open(file,'r')
 print(read_file.read())


 if __name__=="__main__":
   
    main()

