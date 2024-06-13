interface Iresult
{
    totalmarks();
    percentage();
}
class Students implements Iresult
{
 phy:number;
 che:number;
 math:number;
 total:number;
 constructor(p:number,c:number,m:number)
 {
    this.che=c;
    this.math=m;
    this.phy=p
 }
 totalmarks() {
     return this.total= this.che+this.phy+this.math;
 }
 percentage() {
    return (this.total/300)*100;
 }
 StudentsResult()
 {
    console.log(`Physics:${this.phy} Chemistry:${this.che} Math:${this.math} Total:${this.totalmarks()},percentage:${this.percentage()}`);
    
 }

}
let stdObj=new Students(99,55,66);
stdObj.StudentsResult();
