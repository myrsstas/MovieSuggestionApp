using Exercise2._7_Myrsini_Stasinou.Movies;

namespace Exercise2._7_Myrsini_Stasinou;

public class AssembleMovieList
{
    public static void ShowMovieList(List<IMovies> movieList)
    {
            movieList.Add(new FightClub());
            movieList.Add(new ForrestGump());
            movieList.Add(new Inception());
            movieList.Add(new Interstellar());
            movieList.Add(new PulpFiction());
            movieList.Add(new SchindlersList());
            movieList.Add(new TheDarkKnight());
            movieList.Add(new TheGodfather());
            movieList.Add(new TheGodfatherPart2());
            movieList.Add(new TheShawshankRedemptionMovie());
            
            foreach (var movie in movieList)
            {
                Console.WriteLine($"-> {movie.MovieTitle} - {movie.MovieRating}");
            }
            
    }

}