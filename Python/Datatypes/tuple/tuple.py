# # Create a tuple 
# # Homogenus

# student_id = (1,2,3,4,5,6)
# ice_creame = ('Vanilla','Choco-chips','Blueberry')

# # Hetrogenus
# mixed_type = (123,'Hello',False,56.78)


# print("length of student id ",len(student_id))
# print("Blueberry",ice_creame[2])
# print("False ",mixed_type[-2])
# print("'Hello',False",mixed_type[1:3])

# ice_cream=('Vanilla')
# print(ice_cream,type(ice_cream))
# ice_cream=('vanilla',)
# print(ice_cream,type(ice_cream))

ice_cream=('Vanilla','Choco-chips','Blueberry','Vanilla')

#METHODS

#Counts
print(ice_cream.count('Vanilla'))

#Index

print(ice_cream.index('Choco-chips'))

#nested list in tuple

nested_list = (['Shubham','ketan'],[21,22],(True,False))
print(nested_list[0][0])
print(nested_list[0][1])
print(nested_list[1][0])
print(nested_list[1][1])
print(nested_list[2][0])
print(nested_list[2][1])
print(nested_list[2][0:2])