import './App.css';
import BowlerList from './BowlerList'; // Importing the BowlerList component

// heading component
function Welcome() {
  return <h1>List of Bowlers from the Bowling League</h1>;
}

// Main App component that renders the Welcome message and BowlerList component
function App() {
  return (
    <>
      <Welcome />
      <BowlerList />
    </>
  );
}

export default App;
