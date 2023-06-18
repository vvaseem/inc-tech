import { Link, useParams } from "react-router-dom";
import { usePlanet } from '../hooks/usePlanet';

const PlanetDetail = () => {
  const { id } = useParams<{ id: string }>();
  const { planet, loading } = usePlanet(Number(id));

  if (!Number(id)) {
    return <p>Invalid ID parameter. It should be a number.</p>;
  }

  if (loading) {
    return <p>Loading...</p>;
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
