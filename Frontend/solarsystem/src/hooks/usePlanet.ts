import { useEffect, useState } from "react";
import Planet from "../interfaces/Planet";
import { fetchPlanet } from "../api/api";

export const usePlanet = (id: number) => {
  const [planet, setPlanet] = useState<Planet>({} as Planet);
  const [loading, setLoading] = useState<boolean>(true);

  useEffect(() => {
    async function getPlanet() {
      setLoading(true);
      try {
        const response = await fetchPlanet(id);
        setPlanet(response);
      } catch (error) {
        console.error(error);
      } finally {
        setLoading(false);
      }
    }
    getPlanet();
  }, [id]);

  return { planet, loading };
};
