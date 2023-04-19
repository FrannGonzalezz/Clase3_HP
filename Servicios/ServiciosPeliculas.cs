using Clase_3.Models;

namespace Clase_3.Servicios;

public static class ServicioPeli
{
    static List<Pelicula> Peliculas { get; set; }

    static ServicioPeli()
    {
        Peliculas = new List<Pelicula>
        {
            new Pelicula { Código = 1, Nombre = "Piratas del Caribe 1", Género = "Aventura", Duración = 123, Puntuación = 4},
            new Pelicula { Código = 1, Nombre = "Jhon Wick 4", Género = "Acción", Duración = 114, Puntuación = 5},
            new Pelicula { Código = 1, Nombre = "Son como niños", Género = "Comedia", Duración = 98, Puntuación = 3.5},
            new Pelicula { Código = 1, Nombre = "El Conjuro 3", Género = "Terror", Duración = 127, Puntuación = 5},
        };
    }

    public static List<Pelicula> GetAll() => Peliculas;
}