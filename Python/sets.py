staff_id={123,124,125,126}
mixed_type={'Shubam',25,124,True,124}

more_add={'Rahul',24}

# print(mixed_type)
# print(len(mixed_type))

# s1={True,1,0,False}
# print(s1)

# for i in mixed_type:
#     print(i)


#add()-add element to the set

mixed_type.add('admin')
print('Added item :',mixed_type)\


#update() method

mixed_type.update(more_add)
print(mixed_type)

#discard-remove the specified element

mixed_type.discard('Rahul')

print(mixed_type)

