import React, { useEffect, useState } from "react";
import { Link, useParams } from "react-router-dom";
import axios from "axios";
import Planet from "../interfaces/Planet";

const PlanetDetail = () => {
  const { id } = useParams();
  const [planet, setPlanet] = useState<Planet>({} as Planet);

  useEffect(() => {
    axios.get(`https://localhost:7292/api/Planets/${id}`).then((response) => {
      setPlanet(response.data);
    });
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
