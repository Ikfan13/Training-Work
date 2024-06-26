import React, { Component } from 'react'

export default class VirtualDomComp extends Component {

    constructor(props) {
        super(props)
    
        this.state = {
             breakfast:[{id:1 ,name:"Poha"},{id:2,name:"idly"},{id:3,name:"poori"},{id:4,name:"Pongal"}]
        }
    }
    
    render() {
        return (
            <div>
                <h1>THis is VirtualDomCOmp</h1>
                <ul>
                     {this.state.breakfast.map((val,index)=>{
                        return <li key={index}>{val.name}</li>
                     })}


                </ul>
            </div>
        )
    }
}
