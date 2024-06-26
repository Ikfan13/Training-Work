import { Button } from '@mui/material';
import React, { useState } from 'react'

const UseStateHookComp = () => {

    const[count,setcount]=useState(0);
    const[name,setname]=useState("Ikfan");
    const CounterInc=()=>{
        setcount(count+1)
    }
    return (
        <div>
            <h1>UseStateHookComp</h1>
            <p>The count is {count}</p>
            <Button variant='contained' onClick={()=>CounterInc()}>Counter++</Button>{" "}
            <Button variant='contained' onClick={()=>setcount(count-1)}>COunter--</Button>{" "}
            <br></br>
            <p>My name is {name}</p>
            <Button variant='contained' onClick={()=>setname("Mohamed Ikfan")}>ChangeName</Button>{" "}
        </div> 
    )
}

export default UseStateHookComp
