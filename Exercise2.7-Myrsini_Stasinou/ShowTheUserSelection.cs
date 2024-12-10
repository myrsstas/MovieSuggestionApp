namespace Exercise2._7_Myrsini_Stasinou;

public class ShowTheUserSelection
{
    public static bool ShowUserSelection(int userInput, List<IMovies> movies, bool continueMenu)
    {
        switch (userInput)
        {
            case 1:
                BestThreeMovies.ShowBestThreeMovies(movies, continueMenu);
                break;
            case 2:
                WorstThreeMovies.ShowWorstThreeMovies(movies, continueMenu);
                break;
            case 3:
                MoviesWithRankingNineAndUp.ShowMoviesWithRankingNineAndUp(movies, continueMenu);
                break;
            case 0:
                ExitApplication.Exit();
                continueMenu = false;
                break;
            default:
                Console.WriteLine("Please enter a valid number");
                break;
        }
        return continueMenu;
    }
}