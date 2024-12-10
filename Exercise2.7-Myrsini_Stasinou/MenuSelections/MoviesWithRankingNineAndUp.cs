namespace Exercise2._7_Myrsini_Stasinou;

public class MoviesWithRankingNineAndUp
{
    public static bool ShowMoviesWithRankingNineAndUp(List<IMovies> movies, bool continueMenu)
    {
        var moviesWithRankingNineAndUp = movies.Where(m => m.MovieRating >= 9)
            .OrderByDescending(m => m.MovieRating);

        Console.WriteLine("Movies with ranking nine and up:");
        
        foreach (var eachMovie in moviesWithRankingNineAndUp)
        {
            Console.WriteLine($"{eachMovie.MovieTitle} - {eachMovie.MovieRating}");
        }
        
        MovieMenu.ShowMenu();
        
        return continueMenu;
    }
}