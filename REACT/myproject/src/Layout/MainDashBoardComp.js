import React from 'react'
import { Outlet } from 'react-router-dom'
import NavComp from './NavComp'
import FooterComp from './FooterComp'
import { Link } from 'react-router-dom'


const MainDashBoardComp = () => {
    return (
        <div className='card border-primary'>
                <div className='card-header border-primary'>
                    <NavComp></NavComp>
                    <Link to="/" className='btn btn-outline-danger'>SignOut</Link>
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
