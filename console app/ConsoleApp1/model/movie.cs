// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System;
using System.Diagnostics.Contracts;

public class Movie
{
    public string Title { get; set; }
    public string Director { get; set; }
    public int Duration { get; set; }

    public Movie(string title, string director, int duration)
    {
        Title = title;
        Director = director;
        Duration = duration;
    }
}




    
    





