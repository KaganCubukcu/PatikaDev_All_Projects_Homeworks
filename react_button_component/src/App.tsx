import Button from "./components/Button";
import "./App.css";

function App() {
  return (
    <>
      <h1>Custom Button Components</h1>
      <Button
        border="none"
        color="pink"
        height="100px"
        width="200px"
        onClick={() => console.log("You clicked on the pink button!")}
        radius="0%"
        children="Pink Button"
      />
      <br></br>
      <br></br>

      <Button
        border="solid"
        color="#f5bc42"
        height="100px"
        width="200px"
        onClick={() => console.log("You clicked on the orange button!")}
        radius="10%"
        children="Orange Button"
      />
      <br></br>
      <br></br>
      <Button
        border="dashed"
        color="#fdffc4"
        height="100px"
        width="200px"
        onClick={() => console.log("You clicked on the yellow button!")}
        radius="50%"
        children="Yellow Button"
      />
    </>
  );
}

export default App;
