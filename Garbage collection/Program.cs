///////////////////////////////1
//using System;

//class Film : IDisposable
//{
//    public string Title { get; set; }
//    public string Studio { get; set; }
//    public string Genre { get; set; }
//    public int Duration { get; set; }
//    public int Year { get; set; }

//    private bool disposed = false;

//    public Film(string title, string studio, string genre, int duration, int year)
//    {
//        Title = title;
//        Studio = studio;
//        Genre = genre;
//        Duration = duration;
//        Year = year;
//    }

//    public void ShowInfo()
//    {
//        Console.WriteLine($"Назва: {Title}");
//        Console.WriteLine($"Кіностудія: {Studio}");
//        Console.WriteLine($"Жанр: {Genre}");
//        Console.WriteLine($"Тривалість: {Duration} хв");
//        Console.WriteLine($"Рік випуску: {Year}");
//    }

//    public void Dispose()
//    {
//        Dispose(true);
//        GC.SuppressFinalize(this);
//    }

//    protected virtual void Dispose(bool disposing)
//    {
//        if (!disposed)
//        {

//            disposed = true;
//        }
//    }

//    ~Film()
//    {
//        Dispose(false);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Film film = new Film("Сторожова застава", "Kinorob", "Фентезі", 111, 2017);
//        film.ShowInfo();

//        film.Dispose();
//    }
//}



/////////////////////////////////////////2
using System;
using System.Collections.Generic;

class Spectacle : IDisposable
{
    public string Title { get; set; }
    public string Theatre { get; set; }
    public string Genre { get; set; }
    public int Duration { get; set; }
    public List<string> Actors { get; set; }

    private bool disposed = false;

    public Spectacle(string title, string theatre, string genre, int duration, List<string> actors)
    {
        Title = title;
        Theatre = theatre;
        Genre = genre;
        Duration = duration;
        Actors = actors;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Назва спектаклю: {Title}");
        Console.WriteLine($"Театр: {Theatre}");
        Console.WriteLine($"Жанр: {Genre}");
        Console.WriteLine($"Тривалість: {Duration} хв");
        Console.WriteLine("Актори:");
        foreach (var actor in Actors)
        {
            Console.WriteLine($" - {actor}");
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {

            disposed = true;
        }
    }

    ~Spectacle()
    {
        Dispose(false);
        Console.WriteLine($"Деструктор викликано для спектаклю \"{Title}\"");
    }
}

class Program
{
    static void Main()
    {
        using (Spectacle spectacle = new Spectacle(
            "100 тисяч",
            "Національний академічний театр ім. Івана Франка",
            "Комедія",
            90,
            new List<string> { "Степан", "Марко", "Петро", "Олена" }))
        {
            spectacle.ShowInfo();
        }
    }
}