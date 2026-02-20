import React, {useEffect, useState} from 'react';

function App() {
  const [oils, setOils] = useState([]);

  useEffect(() => {
    fetch('/api/oils')
      .then(r => r.json())
      .then(setOils)
      .catch(console.error);
  }, []);

  return (
    <div style={{padding:20}}>
      <h1>SULFUR Web</h1>
      <h2>Oils</h2>
      <ul>
        {oils.map((o, i) => <li key={i}>{o}</li>)}
      </ul>
    </div>
  );
}

export default App;
