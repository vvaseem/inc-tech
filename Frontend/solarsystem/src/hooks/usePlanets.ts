import { useEffect, useState } from "react";
import Planet from "../interfaces/Planet";
import { fetchPlanets } from "../api/api";

export const usePlanets = () => {
  const [planets, setPlanets] = useState<Planet[]>([]);
  const [loading, setLoading] = useState<boolean>(true);

  useEffect(() => {
    async function getPlanets() {
      setLoading(true);
      try {
        const response = await fetchPlanets();
        setPlanets(response);
      } catch (error) {
        console.error(error);
      } finally {
        setLoading(false);
      }
    }
    getPlanets();
  }, []);

  return { planets, loading };
};
