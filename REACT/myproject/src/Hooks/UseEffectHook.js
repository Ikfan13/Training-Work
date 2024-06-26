import React, { useEffect,useState } from 'react'
import { Button } from '@mui/material';

const UseEffectHook = () => {

    const [count,setcount]=useState(0);
    const[salary,setsalary]=useState(20000)
    // case:1
    // useEffect(()=>{
    //     setcount(count+1)
    // })
    // case:2
    // useEffect(()=>{
    //     setcount(count+1)
    // },[])
    // case:3
    useEffect(()=>{
        setcount(count+1)
    },[salary])
    return (
        <div>
            <h1>UseEffectHook </h1>
            <p>The count is {count}</p>
            <p>My salary is {salary}</p>
            <Button variant='contained' onClick={()=>setsalary(salary+1000)}>Counter</Button>{" "}
        </div>
    )
}

export default UseEffectHook
