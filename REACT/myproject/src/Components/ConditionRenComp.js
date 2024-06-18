import { Component } from "react";
import React from "react";

class ConditionRenComp extends Component
{
    
constructor()
{
    super()
    this.state={
        isCond:true
    }
}
 render()
 {  
    let msg;  
    if (this.state.isCond){
    // return <h2>Admin Login Succesfully </h2>}
     msg="Admin Login Succesfully"
 }
    else  {
    //    return <h2>Admin Login UnSuccesfully</h2>
          msg="Admin Login Succesfully"
    }
    return msg
 }
}
export default ConditionRenComp;