import React from 'react'
import { Outlet } from 'react-router-dom'

const ReactHooksComp = () => {
    return (
        <div>
            <h1>This is ReactHooksComponent</h1>
            <Outlet></Outlet>
        </div>
    )
}

export default ReactHooksComp