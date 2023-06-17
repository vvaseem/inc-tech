import "./App.css";
import PlanetDetail from "./components/PlanetDetail";
import PlanetsList from "./components/PlanetList";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";


function App() {
  return (
    <div className="App">
      <header className="App-header">
        <h1>Solar System</h1>
      </header>

      <Router>
        <Routes>
          <Route path="/" element={<PlanetsList />} />
          <Route path="/planet/:id" element={<PlanetDetail />} />
        </Routes>
      </Router>
    </div>
  );
}

export default App;
