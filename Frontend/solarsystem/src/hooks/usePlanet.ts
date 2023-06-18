import { useEffect, useState } from "react";
import Planet from "../interfaces/Planet";
import { fetchPlanet } from "../api/api";

export const usePlanet = (id: number) => {
  const [planet, setPlanet] = useState<Planet>({} as Planet);

  useEffect(() => {
    async function getPlanet() {
      try {
        const response = await fetchPlanet(id);
        // Include type guard here based on the shape of your Planet object
        if (response && 'id' in response && 'name' in response /* include all needed properties here */) {
          setPlanet(response);
        } else {
          throw new Error('Invalid response');
        }
      } catch (error) {
        console.error(error);
      }
    }
    getPlanet();
  }, [id]);

  return { planet };
};
