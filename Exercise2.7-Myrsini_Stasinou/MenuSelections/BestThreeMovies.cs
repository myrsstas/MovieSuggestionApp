using System.Reflection.Metadata.Ecma335;

namespace Exercise2._7_Myrsini_Stasinou;

public class BestThreeMovies
{
    public static bool ShowBestThreeMovies(List<IMovies> movies , bool continueMenu)
    {
        var bestThreeMovies = movies.OrderByDescending(m => m.MovieRating)
            .Take(3);

        Console.WriteLine("Best Three Movies:");
        
        foreach (var eachMovie in bestThreeMovies)
        {
            Console.WriteLine($"{eachMovie.MovieTitle} - {eachMovie.MovieRating}");
        }
        
        MovieMenu.ShowMenu();
        
        return continueMenu;
    }
    
    
    
}