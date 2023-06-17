import { useEffect, useState } from 'react';
import { Link } from "react-router-dom";
import axios from 'axios';

 const PlanetsList = () =>{
    const [planets, setPlanets] = useState([]);

    useEffect(() => {
        axios.get('https://localhost:7292/api/Planets')
            .then(response => {
                setPlanets(response.data);
                console.log("Planets: ", response.data);
            })
            .catch(error => console.error(`There was an error retrieving the list of planets: ${error}`));
    }, []);

    return (
        <main>
            <header>
                <h1>Names of Planets</h1>
            </header>
            
            <section>
                    {planets.map((planet, index) => (
                        <div key={index} style={{margin: "0.5rem"}}>
                            <Link to={`/planet/${planet.id}`}>{planet.name}</Link>
                        </div>
                    ))}
            </section>
        </main>
    );
    
}

export default PlanetsList;
