import React from 'react';

function App() {
  const triggerPowerAutomate = async () => {
    const url = "https://make.powerautomate.com/environments/b662ec51-804f-efa7-9fe3-2ab520133742/flows/dafcd0a7-5f12-41ff-b6e8-19264736d39b/details"; // Replace with your Power Automate URL

    try {
      const response = await fetch(url, {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify({
          message: "Triggered from React!",
        }),
      });

      if (response.ok) {
        console.log("Flow triggered successfully!");
      } else {
        console.error("Failed to trigger Power Automate:", response.statusText);
      }
    } catch (error) {
      console.error("Error calling Power Automate:", error);
    }
  };

  return (
    <div>
      <h1>Power Automate Trigger</h1>
      <button onClick={triggerPowerAutomate}>Trigger Power Automate</button>
    </div>
  );
}

export default App;
