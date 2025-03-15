import { useEffect, useState } from 'react'; // Importing React hooks for state management and side effects

import { bowler } from './types/bowler'; // Importing the bowler type definition

function BowlerList() {
  // State to store the list of bowlers
  const [bowlers, setBowlers] = useState<bowler[]>([]);

  // useEffect to fetch bowler data when the component mounts
  useEffect(() => {
    const fetchBowler = async () => {
      const response = await fetch('http://localhost:5033/Bowler'); // Fetch data from the backend API
      const data = await response.json(); // Parse JSON response
      setBowlers(data); // Update state with fetched data
    };
    fetchBowler(); // Call the fetch function
  }, []); // Empty dependency array ensures this effect runs only once when the component mounts

  // Table displaying bowler information
  // Mapping through the bowlers array and rendering each bowler's data in a table row
  return (
    <>
      <table>
        <thead>
          <tr>
            <th>Bowler Name</th>
            <th>Team Name</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone Number</th>
          </tr>
        </thead>
        <tbody>
          {bowlers.map((b) => (
            <tr key={b.bowlerID}>
              <td>
                {b.bowlerFirstName} {b.bowlerMiddleInit} {b.bowlerLastName}
              </td>
              <td>{b.team.teamName}</td>
              <td>{b.bowlerAddress}</td>
              <td>{b.bowlerCity}</td>
              <td>{b.bowlerState}</td>
              <td>{b.bowlerZip}</td>
              <td>{b.bowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlerList; // Exporting the component for use in other parts of the app
