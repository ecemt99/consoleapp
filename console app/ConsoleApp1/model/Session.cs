public class Session
{ 
    public Movie Movie{get; set;}
    public DateTime StartTime{get; set;}
    public DateTime EndTime { get {return StartTime.AddMinutes(Movie.Duration); } }

    public void Displayinfo()
    {
        Console.WriteLine($"Film: {Movie.Title}");
        Console.WriteLine($"Yönetmen: {Movie.Director}");
        Console.WriteLine($"Başlangıç Zamanı: {StartTime}");
        Console.WriteLine($"Bitiş Zamanı: {EndTime}");
    }

    }
    