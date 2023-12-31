import { Link } from "react-router-dom";
import { usePlanets } from "../hooks/usePlanets";
import "../App.css";

const PlanetsList = () => {
  const { planets, loading, error } = usePlanets();

  if (!loading && planets.length === 0) {
    return <p>No planets found.</p>;
  }

  if (error) {
    return <p>Error: {error}</p>;
  }

  return (
    <main>
      <header>
        <h2 className="planet-list-header">
          {loading ? "Loading..." : `Click on a Planet to learn more about it!`}
        </h2>
      </header>

      <section>
        {planets.map((planet, index) => (
          <div key={planet.id} className="planet-list-item">
            <Link
              to={`/planet/${planet.id}`}
              aria-label={`Link to details about ${planet.name}`}
            >
              {planet.name}
            </Link>
          </div>
        ))}
      </section>
    </main>
  );
};

export default PlanetsList;
