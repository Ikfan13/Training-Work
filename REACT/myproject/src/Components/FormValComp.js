import React, { useState } from 'react'

const FormValComp = () => {

    const [user,setuser]=useState({
        userName:"",
        userPassword:"",
        term:false
    })
    const inputChangeHandler=(event)=>
        {
            const {type,name,value}=event.target;
            setuser({...user,[name]:value})
        }
    const checkData=(event)=>{
        event.preventDefault();
        if(user.userName.trim()==="")
            {
                window.alert("Username is Required")
                return false
            }
        if(!user.userName.trim().match('^[a-zA-Z]{3,20}$'))
        {
            window.alert("User Name must contain only character min-3 and max-20");
            return false;
        }
        if(user.term===false)
            {
                window.alert("Please Accept Term and Condition");
                return false
            }
        window.alert(JSON.stringify(user));    
    }    
    return (
        <div>
              <h1/>FormValComp
              <form onSubmit={checkData}>
                   <label>Enter UserName:</label>
                   <input type='text' name="userName" onChange={inputChangeHandler} value={user.userName}></input>
                   <br/>
                   <label>Enter Password:</label>
                   <input type='text' name="userPassword" onChange={inputChangeHandler} value={user.userPassword}></input>
                   <br/>
                   <label>
                    <input type="checkbox" name="term" onChange={inputChangeHandler} value={user.term} ></input>
                      I Accept Term and Codition
                   </label><br/>
                   <button type="submit" className='btn btn-primary mt-2'>Submit</button>

                </form>          
        </div>
    )
}

export default FormValComp
