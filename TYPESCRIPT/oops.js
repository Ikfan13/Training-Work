"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Person = void 0;
var Person = /** @class */ (function () {
    function Person(name, contact, address, single) {
        //data-member
        this.pname = "Sokker";
        this.pphno = 7550014326;
        this.paddress = "planet unknown";
        this.psingle = true;
        this.pname = name;
        this.pphno = contact;
        this.paddress = address;
        this.psingle = single;
    }
    //member-function
    Person.prototype.personDetails = function () {
        console.log("name:".concat(this.pname, " contact:").concat(this.pphno, " Single:").concat(this.psingle, " Address:").concat(this.paddress));
    };
    return Person;
}());
exports.Person = Person;
// let personObj=new Person("Ikfan",710710,"ramnad",true);
//  personObj.personDetails();
//  let personObj2=new Person("DALA",71456,"Andaman",true);
//  personObj2.personDetails(); 
