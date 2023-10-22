// WhatToWatch
using WhatToWatch;
foreach (var item in Movie.Catalogue())
{
    Console.WriteLine(item);
}
Console.ReadKey();
while (true)
{
    Console.WriteLine("1. What do you feel like watching?");
    Console.WriteLine("2. Add Movie/Series");
    Console.Write("Enter a number: ");
    // Main Menu
    switch (Console.ReadLine())
    {
        case "1":
            Console.Clear();
            Movie.DisplayGenres();
            break;
        case "2":
            Console.Clear();
            Movie.Create();
            break;
        default:
            Console.Clear();
            Console.WriteLine("Invalid Input");
            break;
    }
}

void Generate(Genre genre)
{
    Random r = new Random();
}
