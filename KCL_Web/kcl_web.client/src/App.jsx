import { useEffect, useState } from 'react';
import './App.css';
import {
    MutiTeam,
    Slide
  } from "./components";
import { Route, Router } from 'react-router-dom';
  
function App() {
    const [User, setForecasts] = useState();

    useEffect(() => {
        populateWeatherData();
    }, []);

    const contents = User === undefined
        ? <p><em>Loading... Please refresh once the ASP.NET backend has started. See <a href="https://aka.ms/jspsintegrationreact">https://aka.ms/jspsintegrationreact</a> for more details.</em></p>
        : <table className="table table-striped" aria-labelledby="tabelLabel">
            <thead>
                <tr>
                    <th>Date</th>
                    <th>Temp. (C)</th>
                    <th>Temp. (F)</th>
                    <th>Summary</th>
                </tr>
            </thead>
            <tbody>
                {User.map(use =>
                    <tr key={use.id}>
                        <td>{use.name}</td>
                        <td>{use.password}</td>
                        <td>{use.id}</td>
                        {/*<td>{use.summary}</td>*/}
                    </tr>
                )}
            </tbody>
        </table>;

    return (
        
            <div>
                <Slide />
                <MutiTeam/>
                <div className='page1'>
                    <h1 id="tabelLabel">Weather use</h1>
                    <p>This component demonstrates fetching data from the server.</p>
                    {contents}
                </div>
            </div>

    );
    
    async function populateWeatherData() {
        const response = await fetch('https://65b87570b71048505a88a94e.mockapi.io/est');
        const data = await response.json();
        setForecasts(data);
    }
}

export default App;