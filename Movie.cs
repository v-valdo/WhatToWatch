namespace WhatToWatch;
public class Movie
{
    public string title;
    public string genre;
    public static List<string> Genres = Enum.GetNames(typeof(Genre)).ToList();

    public Movie(string Title, string Genre)
    {
        title = Title;
        genre = Genre;
    }
    public static Movie Create()
    {
        Console.Write("Enter title: ");
        string? title = Console.ReadLine();

        DisplayGenres();

        Console.Write("Enter genre: ");
        if (int.TryParse(Console.ReadLine(), out int c))
        {
            if (c >= 1 && c <= Genres.Count)
            {
                string selectedGenre = Genres[c - 1];
                return new Movie(title, selectedGenre);
            }
            else
            {
                Console.WriteLine("Invalid genre number.");
            }
        }
        return null;
    }
    public static void DisplayGenres()
    {
        int i = 1;
        foreach (var genre in Genres)
        {
            Console.WriteLine($"{i}. {genre}");
            i++;
        }
    }
    public static List<Movie> Catalogue()
    {
        List<string> MovieFile = File.ReadAllLines("movies.csv").ToList();
        List<Movie> Catalogue = new();
        foreach (var TitleGenre in MovieFile)
        {
            var divider = TitleGenre.Split(',');
            string title = divider[0];
            string genre = divider[1];
            Catalogue.Add(new Movie(title, genre));
        }
        return Catalogue;
    }

}
