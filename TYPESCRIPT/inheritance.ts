import { Person } from "./oops";

class Company extends Person
{
    cname:string;
    gstnumber:number;
    state:string;
    constructor(name:string, contact:number, address:string, single:boolean,compName:string,compGst:number,compState:string)
    {
        super(name,contact,address,single);
        this.cname=compName;
        this.gstnumber=compGst;
        this.state=compState;
    }
    personDetails(){
        console.log(`name:${this.pname} contact:${this.pphno} Single:${this.psingle} Address:${this.paddress} CompanyName:${this.cname} GSTnumber:${this.gstnumber} State:${this.state}`);
    }

    


}
let compObj=new Company("DALA",987,"Andaman",true,"ChangePond",12345,"TamilNadu")
compObj.personDetails();
