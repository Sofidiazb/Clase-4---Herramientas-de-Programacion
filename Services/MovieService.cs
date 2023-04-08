using Clase4.Models;

namespace Clase3.Services;

public static class MovieService{
    static List<Movie> Movies { get;set; }
    static MovieService(){
        Movies = new List<Movie>{
            new Movie {Name = "Batman", Code = "BTM", Minutos = 150, Category = "Ciencia Ficcion", Review = "Muy buena."},
            new Movie {Name = "Tarzan", Code = "TRZ", Minutos = 120, Category = "Ciencia Ficcion", Review = "Muy buena."},
            new Movie {Name = "Avatar", Code = "BTM", Minutos = 350, Category = "Ciencia Ficcion", Review = "Muy larga."},
            new Movie {Name = "King Kong", Code = "KK", Minutos = 150, Category = "Ciencia Ficcion", Review = "Muy buena."},
            new Movie {Name = "Mas alla del cielo", Code = "MAC", Minutos = 120, Category = "Drama", Review = "Muy buena."},
            new Movie {Name = "Jhon Wick", Code = "JW", Minutos = 350, Category = "Drama", Review = "Muy larga."},
            new Movie {Name = "Extorsion", Code = "EXT", Minutos = 150, Category = "Drama", Review = "Muy buena."},
            new Movie {Name = "Ataque a la casa blanca", Code = "ACB", Minutos = 120, Category = "Drama", Review = "Muy buena."},
            new Movie {Name = "Buscando a nemo", Code = "BAN", Minutos = 130, Category = "Animada", Review = "Excelente."}
        };
    }
    public static List<Movie> GetAll() => Movies;
    public static void Add(Movie obj){
        if (obj == null){
            return;
        } else{
            Movies.Add(obj);
        }
        
    }
    public static void Delete(string code){
        var movieToDelete = Get(code);
        if(movieToDelete != null){
            Movies.Remove(movieToDelete);
        }
    }
    public static Movie? Get(string code) => Movies.FirstOrDefault(x => x.Code.ToLower() == code.ToLower());

    
}

