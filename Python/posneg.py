list=[1,-22,3,-4,-66,7,0,-8,0]
pos=[]
neg=[]
for i in list:
    if(i>0):
        pos.append(i)
    elif(i<0):
        neg.append(i)
    else:
        print(i)

print(pos)
print(neg)