import axios from 'axios';
import Planet from "../interfaces/Planet"

export const fetchPlanets = async () => {
  try {
    const response = await axios.get<Planet[]>(process.env.REACT_APP_API_URL + '/Planets');
    return response.data;
  } catch (error) {
    console.error(`There was an error retrieving the list of planets: ${error}`);
    throw error;
  }
};

export const fetchPlanet = async (id: number) => {
  try {
    const response = await axios.get<Planet>(process.env.REACT_APP_API_URL + `/Planets/${id}`);
    return response.data;
  } catch (error) {
    console.error(`There was an error retrieving the planet: ${error}`);
    throw error;
  }
}