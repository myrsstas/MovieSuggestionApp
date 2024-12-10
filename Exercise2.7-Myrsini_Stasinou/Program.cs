/*
 * Άσκηση 2.7
Δημιουργήστε ένα console application το οποίο θα δείχνει στον χρήστη μια λίστα 
από 10 τίτλους ταινιών με το rating τους 
(πχ. από το IMDB: https://www.imdb.com/chart/top/?ref_=nv_mv_250 )
Το app θα πρέπει να δείχνει τις παρακάτω επιλογές στον χρήστη:
1 - Δείξε μου τις 3 καλύτερες ταινίες
2 - Δείξε μου τις 3 χειρότερες ταινίες
3 - Δείξε μου όλες τις ταινίες με rating μεγαλύτερο ή ίσο του 9.0
Θα πρέπει να χρησιμοποιηθούν generic collections και όχι arrays
Error handling
Interface implementations όπου χρειάζεται
Επιλογή “0” (μηδέν) για έξοδο από το πρόγραμμα
 */

namespace Exercise2._7_Myrsini_Stasinou;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello and Welcome to Our Movie List Suggestion App. These are our movies: ");
        
        var movieList = new List<IMovies>();
        AssembleMovieList.ShowMovieList(movieList);

        MovieMenu.ShowMenu();
        
        UserInput.UseUserInput(movieList);
        
    }
}