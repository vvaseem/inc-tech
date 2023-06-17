import React, {useEffect, useState} from 'react'
import { useParams } from 'react-router-dom'
import {Link} from "react-router-dom";
import axios from 'axios'

const PlanetDetail = () => {
    const { id } = useParams()
    const [planet, setPlanet] = useState([])

    useEffect(() => {
        axios.get(`https://localhost:7292/api/Planets/${id}`)
            .then(response => {
                console.log("PlanetDetail Response: ", response.data)
                setPlanet(response.data)
            })
    }, [id])

  return (
    <main>
        <header>
            <h1>{planet.name}</h1>
        </header>

        <section>
                <figure>
                    <img src={planet.imageURL} alt={planet.name} />
                    <figcaption>Surface of {planet.name}</figcaption>
                </figure>

                <article>
                    <p><strong>Distance from Sun:</strong> {planet.distanceFromSun}</p>
                    <p><strong>Mass:</strong> {planet.mass}</p>
                    <p><strong>Diameter:</strong> {planet.diameter}</p>
                </article>
            </section>

        <nav>
            <Link to="/">Back Home</Link>
        </nav>

    </main>
  )
}

export default PlanetDetail