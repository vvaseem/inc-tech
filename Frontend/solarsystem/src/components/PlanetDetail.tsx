import { useEffect, useState } from "react";
import { Link, useParams } from "react-router-dom";
import Planet from "../interfaces/Planet";
import { fetchPlanet } from "../api/api";

const PlanetDetail = () => {
  const { id } = useParams();
  const [planet, setPlanet] = useState<Planet>({} as Planet);

  useEffect(() => {
    async function getPlanet() {
      const response = await fetchPlanet(Number(id));
      setPlanet(response);
    }

    getPlanet();
  }, [id]);

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
