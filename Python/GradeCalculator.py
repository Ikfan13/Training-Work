def  marks():
    marks={}
    for i in range(5):
        subject=input("Enter the Subject Name :")
        value=int(input("Enter the mark"))
        marks[subject]=value

    return marks
def calculategrade(calgrade,result):
    for i in calgrade.keys():
        if calgrade[i]>=90:

            print(f'{i} Mark : {calgrade[i]} Grade : {result[90]}')

        elif  calgrade[i]<90 and calgrade[i]>=80 :

            print(f'{i} Mark : {calgrade[i]} Grade : {result[80]}')

        elif  calgrade[i]<80 and calgrade[i]>=70:

            print(f'{i} Mark : {calgrade[i]} Grade : {result[70]}')

        elif  calgrade[i]<70 and calgrade[i]>=60:

            print(f'{i} Mark : {calgrade[i]} Grade : {result[60]}')

        elif calgrade[i]<60 and calgrade[i]>=50:

            print(f'{i} Mark : {calgrade[i]} Grade : {result[50]}')

        else:
            print(f'{i} Mark : {calgrade[i]} Grade : F')
                      

    



def main():
    result={90:'O',
            80:'A+',
            70:'A',
            60:'B+',
            50:'B'
            }
    
    mark=marks()
    print(mark)
    calculategrade(mark,result)
    print()

if __name__=="__main__":
    main()
