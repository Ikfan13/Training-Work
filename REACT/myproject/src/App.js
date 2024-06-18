// import logo from './logo.svg';
import './App.css';
import FunctionComp from './Components/FunctionComp';
import ClassComp from './Components/ClassComp';
import MyDetails from './Components/MyDetails'
import MethodEvent from './Components/MethodEvent';
import SetStateComponent from './Components/SetStateComp';
import ConditionRenComp from './Components/ConditionRenComp';
import MyImagesComp from './Components/MyImagesComp';
function App() {
  return (
    <div className="App">
      {/* <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.js</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header> */}
      <h2>Welcome to the world</h2>

      {/* <FunctionComp myName="Mohamed Ikfan" post="Cheif Executive Officer"/>
      <ClassComp myName="Mohamed Ikfan" post="Cheif Executive Officer"/>
      <MyDetails Fname="Itadori" Lname="Yuji" Email="ItadoriYuji11@gmail.com" Contact="564738284585"></MyDetails>
       <MethodEvent></MethodEvent>  
       <SetStateComponent></SetStateComponent>  */}
       <ConditionRenComp></ConditionRenComp>
       <MyImagesComp></MyImagesComp>
    </div>
  );
}

export default App;
