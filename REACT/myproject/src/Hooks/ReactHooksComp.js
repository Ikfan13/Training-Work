import React from 'react'
import { Link,Outlet } from 'react-router-dom'

const ReactHooksComp = () => {
    return (
        <div>
            <h1>This is ReactHooksComponent</h1>
            <div>
            <Link to="usestate" className='btn btn-primary btn-sm'>useState</Link>{" "}
            <Link to="useeffect" className='btn btn-primary btn-sm'>useeffect</Link>{" "}
            </div>
            <Outlet></Outlet>
        </div>
    )
}

export default ReactHooksComp