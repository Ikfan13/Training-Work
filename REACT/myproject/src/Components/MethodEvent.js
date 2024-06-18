import { Component } from "react";
import React from "react";
class MethodEvent extends Component
{
    greeeting=()=>
        {
            window.alert("Vanakam da Mapla Marsla irunthu");
        }
    Welcome=(...std)=>
        {
            window.alert(`Always Welcome You ${std}`);
        }

    render()
    {
        return <div>
                 <h2>This is Method Event Component</h2>
                 <button type="button" onClick={this.greeeting}>Greeting</button>
                 <button type="button" onClick={()=>this.Welcome("Ik")}>Welcome</button>
               <h2 onMouseOver={()=>this.greeeting()}>Hover on me to get greetings</h2>
        </div>
    }
}
export default MethodEvent;