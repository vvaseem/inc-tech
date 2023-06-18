import { useEffect, useState } from "react";
import { Link } from "react-router-dom";
import Planet from "../interfaces/Planet";
import { fetchPlanets } from "../api/api";

const PlanetsList = () => {
  const [planets, setPlanets] = useState<Planet[]>([]);

  useEffect(() => {
    async function getPlanets() {
      const response = await fetchPlanets();
      setPlanets(response);
    }
    getPlanets();
  }, []);


  return (
    <main>
      <header>
        <h2 style={{ color: "black" }}>Click on a Planet's name to see more info</h2>
      </header>

      <section>
        {planets.map((planet, index) => (
          <div key={index} style={{ margin: "0.5rem" }}>
            <Link to={`/planet/${planet.id}`}>{planet.name}</Link>
          </div>
        ))}
      </section>
    </main>
  );
};

export default PlanetsList;
