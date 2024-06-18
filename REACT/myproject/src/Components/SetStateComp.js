import React, { Component } from "react";

class SetStateComponent extends Component
{
    constructor()
    {
        super();
        this.state={count:0,Name:"Ikfan"}
    }
    CounterInc()
    {
        this.setState({count:this.state.count+1})
    }
    CounterDec()
    {
        this.setState({count:this.state.count-1})
    }
    FullName()
    {
        this.setState((prevstate)=>({Name:prevstate.Name="Mohamed Ikfan M"}))
    }
    render()
    {
        return <div>
            <h2>This is a Set state Component</h2>
            <p>The MyName is <strong>{this.state.Name}</strong></p>
            <p>The Count Value is <strong>{this.state.count}</strong></p>
            <button type="button" onClick={()=>this.CounterInc()}>Inc</button>
            <button type="button" onClick={()=>this.CounterDec()}>Dec</button>
            <button type="button" onClick={()=>this.FullName()}>FullName</button>
        </div>
    }
}
export  default SetStateComponent; 