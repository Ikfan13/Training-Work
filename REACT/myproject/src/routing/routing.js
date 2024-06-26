import { createBrowserRouter } from "react-router-dom";
import MyImagesComp from "../Components/MyImagesComp";
import { MySliderComp } from "../Components/MySliderComp";
import ParentComp from "../Components/ParentComp";
import { PageNotFound } from "../Components/PageNotFound";
import ReactHooksComp from "../Hooks/ReactHooksComp";
import UseStateHookComp from "../Hooks/UseStateHookComp";
import UseEffectHook from "../Hooks/UseEffectHook";
import MainDashBoardComp from "../Layout/MainDashBoardComp";
import VirtualDomComp from "../Components/VirtualDomComp";
import FormValComp from "../Components/FormValComp";
import ProductDashboard from "../CRUD/ProductDashboard";
import ProductAddComp from "../CRUD/ProductAddComp";
import ProductUpdateComp from "../CRUD/ProductUpdateComp";
import LoginComp from "../Layout/LoginComp";
import ProtectRouting from "./ProtectRouting";
// import HOCComp from "../Components/HOCComp";


const router = createBrowserRouter([
// default.routing
    {path:"",element:<LoginComp></LoginComp>},
    {path:"maindashboard",element:<ProtectRouting Component={MainDashBoardComp}/>,children:[
    {path:"MySliderImg",element:<MySliderComp/>},
    {path:"productadd",element:<ProductAddComp></ProductAddComp>},
    {path:"productupdate/:id",element:<ProductUpdateComp></ProductUpdateComp>},

// naming.routing
  {path:"myslider",element:<MySliderComp/>},  
  {path:"myimages",element:<MyImagesComp />},
  {path:"formval",element:<FormValComp></FormValComp>},
  {path:"productdashboard",element:<ProductDashboard></ProductDashboard>},
  
//   parameterized.routing
{path:"parent/:id",element:<ParentComp />}, 
{path:"parent",element:<ParentComp />},
{path:"reacthooks",element:<ReactHooksComp/>},
{path:"virtualdom",element:<VirtualDomComp/>}
]} ,
{path:"productadd",element:<ProductAddComp/>},
///
{path:"*",element:<PageNotFound/>},


{path:"reacthooks",element:<ReactHooksComp/>,children:[
  {path:"usestate", element:<UseStateHookComp/>},
  {path:"useeffect", element:<UseEffectHook/>}
]}
])

export default router;