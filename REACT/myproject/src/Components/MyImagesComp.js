import React, { Component } from 'react'
import sammu from '../shared/Images/image-79gc4p3mqu7an848.jpg'
import staticData from '../shared/Constant/Constantdata'
export class MyImagesComp extends Component {
    render() {
        return (
            <div>
                <img src={sammu}></img>
                <img src={staticData.a}></img>
                <img src={staticData.b}></img>
                <img src={staticData.c}></img>
                <img src={staticData.d}></img>
            </div>
        )
    }
}

export default MyImagesComp
