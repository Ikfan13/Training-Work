import React, { Component, Fragment } from 'react'
import ChildComponent from './ChildComponent'

export class ParentComp extends Component {
    constructor(props) {
        super(props)
    
        this.state = {
            empname:"ARASU",
            empsal:95000 
        }
    }
    ChangeData=()=>{
        this.setState((prevState)=>({empsal:prevState.empsal+10000}))
    }
    render() {
        return (
            <Fragment>
                <h2>This is parent Component</h2>
                <p>Employee Name is : <strong>{this.state.empname}</strong></p>
                <p>Employee Salary is : <strong>{this.state.empsal}</strong></p>
                <button type="button" onClick={()=>this.ChangeData()}>Change</button>
                <hr/>
                <ChildComponent name={this.state.empname} salary={this.state.empsal} ChangeData={()=>this.ChangeData()}></ChildComponent>
            </Fragment>
        )
    }
}

export default ParentComp