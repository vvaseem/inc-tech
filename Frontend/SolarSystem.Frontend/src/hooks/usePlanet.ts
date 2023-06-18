import { useEffect, useState } from "react";
import Planet from "../interfaces/Planet";
import { fetchPlanet } from "../api/api";

export const usePlanet = (id: number) => {
  const [planet, setPlanet] = useState<Planet>({} as Planet);
  const [loading, setLoading] = useState<boolean>(true);
  const [error, setError] = useState<string>("");

  useEffect(() => {
    async function getPlanet() {
      setLoading(true);
      try {
        const response = await fetchPlanet(id);
        console.log("response", response);
        setPlanet(response);
      } catch (error) {
        if (error instanceof Error) {
          setError(error.message);
        }
      } finally {
        setLoading(false);
      }
    }
    getPlanet();
  }, [id]);

  return { planet, loading, error };
};
