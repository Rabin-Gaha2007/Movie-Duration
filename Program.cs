
        Movie[] movies = new Movie[5]
        {
            new Movie("Kabaddi Kabaaddi", 130),
            new Movie("Avatar: The Way of Water", 200),
            new Movie("The Dark Knight", 150),
            new Movie("Drishyam", 170),
            new Movie("Spider-Man: Across the Spider-Verse", 120)
        };

        Console.WriteLine("Movies List:");
        int index = 1;
        int totalDuration = 0;

        foreach (Movie m in movies)
        {
            Console.WriteLine($"{index}. {m.Title} - {m.Duration} mins");
            totalDuration += m.Duration;
            index++;
        }

        Console.WriteLine($"\nTotal duration of all movies: {totalDuration} mins");

       
        Console.WriteLine("\nEnter a movie title to search:");
        string searchTitle = Console.ReadLine();
        bool found = false;

        foreach (Movie m in movies)
        {
            if (m.Title.Equals(searchTitle, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Found:");
                Console.WriteLine($"{m.Title} - {m.Duration} mins");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Movie not found!");
        }
    
public class Movie
{
    public string Title;
    public int Duration;

    public Movie()
    {
        Title = "Untitled";
        Duration = 0;
    }

    public Movie(string title)
    {
        Title = title;
        Duration = 90; 
    }

    public Movie(string title, int duration)
    {
        Title = title;
        Duration = duration;
    }
}
