import { createBrowserRouter } from "react-router-dom";
import MyImagesComp from "../Components/MyImagesComp";
import { MySliderComp } from "../Components/MySliderComp";
import ParentComp from "../Components/ParentComp";
import { PageNotFound } from "../Components/PageNotFound";
import ReactHooksComp from "../Hooks/ReactHooksComp";
import UseStateHookComp from "../Hooks/UseStateHookComp";
import UseEffectHook from "../Hooks/UseEffectHook";
import MainDashBoardComp from "../Layout/MainDashBoardComp";
// import HOCComp from "../Components/HOCComp";


const router = createBrowserRouter([
// default.routing
    {path:"maindashboard",element:<MainDashBoardComp/>,children:[
    {path:"",element:<MySliderComp/>},

// naming.routing
  {path:"myslider",element:<MySliderComp/>},  
  {path:"myimages",element:<MyImagesComp />}, 
  
//   parameterized.routing
{path:"parent/:id",element:<ParentComp />}, 
{path:"parent",element:<ParentComp />},
{path:"reacthooks",element:<ReactHooksComp/>}
]} ,
///
{path:"*",element:<PageNotFound/>},

{path:"reacthooks",element:<ReactHooksComp/>,children:[
  {path:"usestate", element:<UseStateHookComp/>},
  {path:"useeffect", element:<UseEffectHook/>}
]}

])

export default router;