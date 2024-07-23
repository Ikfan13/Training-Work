def areaofcircle(radius,pi=3.14):
       
       print('argument',radius)
       print('PI Value',pi)
       result=radius*radius*pi
       return result
def main():
    #    print('Area of circule is',areaofcircle(1))

    print('Area of circle is :',areaofcircle(pi=3,radius=12))
    print('Area of circle is :',areaofcircle(3))

if __name__=="__main__":
       main()