namespace Exercise2._7_Myrsini_Stasinou;

public class MovieMenu
{
    public static void ShowMenu()
    {
        Console.WriteLine("\nYou can't decide what to watch yet? Select one of the options below: ");
        
        Dictionary<int, string> movieMenuDict = new Dictionary<int, string>();
        movieMenuDict.Add(1, "Best 3 Movies (according to rating)");
        movieMenuDict.Add(2, "Worst 3 Movies (according to rating)");
        movieMenuDict.Add(3, "Movies with rating from 9 and up");
        movieMenuDict.Add(0, "Exit");
        
        foreach (var eachItem in movieMenuDict)
        {
            Console.WriteLine($"{eachItem.Key} - {eachItem.Value}");
        }

    }

}