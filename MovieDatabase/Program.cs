

using MovieDatabase;

Console.WriteLine("Welcome to the Movie List Application!");
Console.WriteLine("There are 10 movies you can pick from.");

List<Movie> allTheMovies = new List<Movie>();
allTheMovies.Add(new Movie("Iron Man", "Action"));
allTheMovies.Add(new Movie("Fast and Furious", "Action"));
allTheMovies.Add(new Movie("Starship Troopers", "SciFi"));
allTheMovies.Add(new Movie("Titanic", "Romance"));
allTheMovies.Add(new Movie("Jaws", "Thriller"));
allTheMovies.Add(new Movie("Inception", "Thriller"));
allTheMovies.Add(new Movie("Ready Player One", "SciFi"));
allTheMovies.Add(new Movie("The Notebook", "Romance"));
allTheMovies.Add(new Movie("Rent", "Musicals"));
allTheMovies.Add(new Movie("Hairspray", "Musicals"));


Console.WriteLine("What category are you interested in? \nYou can pick from Action, SciFi, Thriller, Romance, or Musicals");

while (true)
{
    string category = Console.ReadLine();
    if (category == "Action" || category == "SciFi" || category == "Romance" || category == "Thriller" || category == "Musicals")
    {
        foreach (Movie movie in allTheMovies)
        {
            Console.WriteLine(movie.DisplayMovies());
        }
        break;
    }
    else
    {
        Console.WriteLine("That is not a valid category. Please select a category:");
    }
}


