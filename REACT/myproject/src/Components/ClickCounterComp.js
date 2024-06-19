import React, { Component } from 'react'
import { HocComp } from './HocComp';
import Button from '@mui/material/Button';


class ClickCounterComp extends Component {


// constructor(props) {
//     super(props)

//     this.state = {
//          count:0
//     }
// }

// counterInc = ()=>{
//     // this.setState({count:this.state.count+1});
//     this.setState((prevState)=>({count:prevState.count+1}))
// }

    render() {
        return (
            <div>
                <h2>This ClickCounter Component Output</h2>
  <h2>This Count Value is {this.props.count}</h2>
  {/* <button type="button" className='btn btn-danger' onClick={()=>this.props.counterInc()}>Count++</button> &nbsp; */}
  <Button variant="contained" onClick={()=>this.props.counterInc()}>Count++</Button>
            </div>
        )
    }
}

export default HocComp(ClickCounterComp);