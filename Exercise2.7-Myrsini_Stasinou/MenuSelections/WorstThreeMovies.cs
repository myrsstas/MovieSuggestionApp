namespace Exercise2._7_Myrsini_Stasinou;

public class WorstThreeMovies
{
    public static bool ShowWorstThreeMovies(List<IMovies> movies, bool continueMenu)
    {
        var worstThreeMovies = movies.OrderBy(m => m.MovieRating)
            .Take(3);
        Console.WriteLine("Worst Three Movies:");
        foreach (var eachMovie in worstThreeMovies)
        {
            Console.WriteLine($"{eachMovie.MovieTitle} - {eachMovie.MovieRating}");
        }
        
        MovieMenu.ShowMenu();
        
        return continueMenu;
    }

}