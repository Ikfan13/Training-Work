import React from 'react'
import staticData from '../shared/Constant/Constantdata'
import './external.css'
import mymodule from './mymodule.module.css'

 const MyCssComp = () => {
    const txtObj={
            color:true?"green":"red",
            fontSize:!false?"20px":"30px",
            backgroundColor:!true?"pink":"lightgray"
    }
    
    
    return (
       
        <>
            <h1 style={{color:"red"}}>This is CSS Component</h1>
            <p style={txtObj}>Singam Singam He's DuraiSinga,</p>
            <img className="img" src={staticData.a}/><br/>
            <img className={mymodule.box}  src={staticData.b}/>

        </>
        
    )
}
export default MyCssComp
