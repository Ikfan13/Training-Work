import React from 'react'
import { Outlet } from 'react-router-dom'
import NavComp from './NavComp'
import FooterComp from './FooterComp'


const MainDashBoardComp = () => {
    return (
        <div className='card border-primary'>
                <div className='card-header border-primary'>
                    <NavComp></NavComp>
                </div>
                <div className='card-header border-primary'>card-nav
                    <Outlet></Outlet>
                </div>
                <div className='card-header border-primary'>
                    <FooterComp/>
                </div>
                
            </div>
    )
}

export default MainDashBoardComp
