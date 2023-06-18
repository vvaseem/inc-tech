import { Link } from "react-router-dom";
import { usePlanets } from '../hooks/usePlanets';

const PlanetsList = () => {
  const { planets, loading } = usePlanets();

  return (
    <main>
      <header>
        <h2 style={{ color: "black" }}>
          {
            loading ? "Loading..." : `Click on a Planet to learn more about it!`
          }
        </h2>
      </header>

      <section>
        {planets.map((planet, index) => (
          <div key={planet.id} style={{ margin: "0.5rem" }}>
            <Link to={`/planet/${planet.id}`} aria-label={`Link to details about ${planet.name}`}>{planet.name}</Link>
          </div>
          
        ))}
      </section>
    </main>
  );
};

export default PlanetsList;
