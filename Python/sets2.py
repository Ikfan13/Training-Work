company={'Infosys','ICIC bank','TCS','Bajaj'}
add_company={'SBI','Infosys','Tata Consultancy','TCS'}

union_method=company.union(add_company)
print(union_method)

union_method1=company | add_company
print(union_method1)

intersection_method=company.intersection(add_company)
print(intersection_method)


intersection_method1=company & add_company
print(intersection_method1)

difference_method=company.difference(add_company)
print(difference_method)