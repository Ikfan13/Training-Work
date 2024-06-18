import React, { Component } from 'react'

class ClassComp extends Component
{
     constructor()
     {
        super()
        this.state={
            company:"Mars Mission",
            salary:4102038485934000,

        }
     }
    render(props)
    {
        const {company,salary}=this.state;
        const {myName ,post}=this.props;
        return <div>
            <h2>This is Class Component</h2>
            <p>My name is {myName} and I am {post} of a GL</p>
            <p>There will be a event which is called {company} with the winning amount of {salary}</p>

</div>    

    }
}
export  default ClassComp;