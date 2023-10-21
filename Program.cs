// WhatToWatch
using WhatToWatch;

Console.WriteLine("What do you feel like watching?");
string[] Genres = Enum.GetNames(typeof(Genre));

foreach (var genreName in Genres)
{
    Genre genre = (Genre)Enum.Parse(typeof(Genre), genreName);
    Console.WriteLine($"{(int)genre}. {genreName}");
}

switch (Console.ReadLine())
{
    case "1":
        
        break;
    case "2":
        break;
    case "3":
        break;
    case "4":
        break;
    default:
        Console.WriteLine("Invalid input");
        break;
}

void Generate(Genre genre)
{
    Random r = new Random();
}
