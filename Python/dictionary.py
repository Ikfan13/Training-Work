# watch_details={
#     'Titan':5000,
#     'Fasttrack':4000,
#     'Omega':6000
# }

# print(f'length of the dictionary:{len(watch_details)},\ntype of the object is{type(watch_details)}')

# print('using key',watch_details['Titan'])


watch_details={
    'Titan':8000,
    'Fasttrack':5000,
    'Omega':9000,
    'Cartier': 8000
}
# print('Watches Available',watch_details) #Titan (considered the latest key)
# print(len(watch_details))
# print(type(watch_details))
# print('Using Key',watch_details['Titan'])
# print('Using Key',watch_details['Cartier'])

# watch_details['Omega']=23000
# print('After Modifying',watch_details)

# watch_details['Casio']=1600

# print('New Watch added',watch_details)

#key()->returns the list containing the dictionary's keys

key_method=watch_details.keys()
print(key_method)

#value Method-returns the value of the dictionary

value_method=watch_details.values()
print(value_method)


#get method->returns the value of the specified key
get_method=watch_details.get('Titan')
print(get_method)

#items
item_method=watch_details.items()
print(item_method)

#update method => Insert an item to the dictionary
watch_details.update ({'Noise':12000})
print('Update Method:',watch_details)

#pop method=>remove element with the specified key
watch_details.pop('Titan')
print('Pop method:',watch_details)

#Create

# Food_Items={'Idly':10,'Dosai':35,'Poori':30,'Pongal':25,'Vada':10,'Meals':70,'Chappathi':15}

# print(Food_Items)
# print(Food_Items['Pongal'])
# Food_Items['Poori']=40
# print("After modifiying",Food_Items)
# Food_Items['Biriyani']=150
# print("after adding",Food_Items)




# user = {
#     'Vijaybag' : {
#         'firstname' :'Joseph',
#         'lastname' : 'Kuruvila',
#         'location' : 'kerala'
#     },
#      'Ajithbag' : {
#         'firstname' :'Ganggster',
#         'lastname' : 'Ganesh',
#         'location' : 'kolkata'
#     },
#     'rajibag' : {
#         'firstname' :'Adithya',
#         'lastname' : 'Arunachalam',
#         'location' : 'Chennai'
#     }
# }

# print(user['Vijaybag']['firstname'])

# print(user['rajibag']['location'])

# print(user.items())

