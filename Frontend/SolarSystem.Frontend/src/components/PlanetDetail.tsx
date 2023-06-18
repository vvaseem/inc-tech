import { Link, useParams } from "react-router-dom";
import { usePlanet } from "../hooks/usePlanet";

const PlanetDetail = () => {
  const { id } = useParams<{ id: string }>();
  const { planet, loading, error } = usePlanet(Number(id));

  if (loading) {
    return <p key="loading">Loading...</p>;
  }

  if (!loading && !planet) {
    return <p key="not-found">Planet not found.</p>;
  }

  if (!Number.isNaN(id) || Number(id) < 1) {
    return (
      <p key="invalid-id">
        Invalid ID parameter. It should be a positive number.
      </p>
    );
  }

  if (error) {
    return <p key="error">Error: {error}</p>;
  }

  return (
    <main>
      <header>
        <h1>{planet.name}</h1>
      </header>

      <section>
        <figure>
          <img src={planet.image} alt={planet.name} />
          <figcaption>Surface of {planet.name}</figcaption>
        </figure>

        <article>
          <p>
            <strong>Distance from Sun:</strong> {planet.distanceFromSun}
          </p>
          <p>
            <strong>Mass:</strong> {planet.mass}
          </p>
          <p>
            <strong>Diameter:</strong> {planet.diameter}
          </p>
        </article>
      </section>

      <nav>
        <Link to="/">Back Home</Link>
      </nav>
    </main>
  );
};

export default PlanetDetail;
