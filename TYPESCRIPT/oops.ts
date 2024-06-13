 export class Person
{
    //data-member
    pname:string="Sokker";
    pphno:number=7550014326;
    paddress:string="planet unknown"
    psingle:boolean=true;

    constructor(name:string, contact:number, address:string, single:boolean)
    {
        this.pname=name;
        this.pphno=contact;
        this.paddress=address;
        this.psingle=single;
    }
    //member-function
    personDetails()
    {
        console.log(`name:${this.pname} contact:${this.pphno} Single:${this.psingle} Address:${this.paddress}`);

    }
}
// let personObj=new Person("Ikfan",710710,"ramnad",true);
 
//  personObj.personDetails();

//  let personObj2=new Person("DALA",71456,"Andaman",true);
 
//  personObj2.personDetails(); 