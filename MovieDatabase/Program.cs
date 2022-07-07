

using MovieDatabase;

Console.WriteLine("Welcome to the Movie List Application!");
Console.WriteLine("There are 10 movies you can pick from.");

List<Movie> movies = new List<Movie>()
{
    new Movie("Iron Man", "Action"),
    new Movie("Fast and Furious", "Action"),
    new Movie("Starship Troopers", "SciFi"),
    new Movie("Titanic", "Romance"),
    new Movie("Jaws", "Thriller"),
    new Movie("Inception", "Thriller"),
    new Movie("Ready Player One", "SciFi"),
    new Movie("The Notebook", "Romance"),
    new Movie("Rent", "Musicals"),
    new Movie("Hairspray", "Musicals")
};

bool runProgram = true;

while (runProgram)
{
    Console.WriteLine("What category are you interested in? \nYou can pick from Action, SciFi, Thriller, Romance, or Musicals");
    string category = Console.ReadLine();

    List<Movie> result = new List<Movie>();

    foreach(Movie m in movies)
    {
        if(m.Category == category)
        {
            result.Add(m);
        }
    }
    
    foreach(Movie m in result)
    {
        Console.WriteLine(m.Title);
    }

    while (true)
    {
        Console.WriteLine("Continue? y/n: ");
        string cont = Console.ReadLine().ToLower().Trim();

        if (cont == "y")
        {
            break;
        }
        else if(cont == "n")
        {
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("That was not y/n");
        }
        
    }
}


