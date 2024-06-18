import React, { Component } from 'react'

class MyDetails extends Component
{
    constructor()
    {
        super();
        this.state={
                Gender:"Male",
                Martial_Status:"Unmarried",
                Address:"Tokyo"
        }


    }
    render(props)
    {
        const {Fname,Lname,Email,Contact}=this.props;
        const {Gender,Martial_Status,Address}=this.state;
        return <div>
               <p>FNAME:{Fname} LNAME:{Lname} GENDER:{Gender} MARTIAL_STATUS:{Martial_Status} EMAIL:{Email} CONTACT:{Contact} ADDRESS:{Address}</p>

        </div>
    }

}
export  default MyDetails;