namespace Exercise2._7_Myrsini_Stasinou;

public class UserInput
{
    public static void UseUserInput(List<IMovies> movieList)
    {
        bool continueMenu = true;

        while (continueMenu)
        {
            try
            {
                int userInput = Convert.ToInt32(Console.ReadLine());
                continueMenu = ShowTheUserSelection.ShowUserSelection(userInput,movieList,continueMenu);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("You entered an invalid selection. Please try again: ");
                MovieMenu.ShowMenu();
            }
        }
                
    }
    
}