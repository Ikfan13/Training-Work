console.log("ALWAYS WELCOMES YOU")

//1.number
  let num1:number=100,num3:number=200,num2:number=300;

  console.log(num1,num2,num3);

  //2.String
  let fname:string="Ikfan",lname:string="Mohamed";
  //3.boolean
   let cond1:boolean = true,cond2:boolean=false;
   console.log(cond1,cond2);

   //4.array
   let students:string[]=["Nirmal","Sandhya","Sindhuja","Rithika","Supraja"];
   let emp:Array<string>=["Ikfan","Karthik","Vignesh"];

   //5.tuple data:it allow user to store multiple type of data in array

   let product:[number,string]=[101,"Laptop"];

   //6.enum data:it is use to create constant variable with value
   
   enum days{ sun , mon, tue=101 , wed , thus , fri , sat};

   //7.union data:it allow user to store multiple type of data in single variable
   let items:string|number=212456;

   //8.any:
   let futuredata:any=456;

 