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
            new Pelicula { Código = 2, Nombre = "Jhon Wick 4", Género = "Acción", Duración = 114, Puntuación = 5},
            new Pelicula { Código = 3, Nombre = "Son como niños", Género = "Comedia", Duración = 98, Puntuación = 3.5},
            new Pelicula { Código = 4, Nombre = "El Conjuro 3", Género = "Terror", Duración = 127, Puntuación = 5}
        };
    }

    public static List<Pelicula> GetAll() => Peliculas;

    public static void Add(Pelicula obj)
    {
        if (obj == null)
        {
            return;
        }
        Peliculas.Add(obj);
    }

    public static Pelicula? Get(int codigo) => Peliculas.FirstOrDefault(x => x.Código == codigo);

    public static void Eliminar(int codigo)
    {
        var peliABorrar = Get(codigo);
        if (peliABorrar != null)
        {
            Peliculas.Remove(peliABorrar);
        }
    }
}