using System;

public class Resume
{
    public string name {get; set;}
    public List<Job> jobs {get; set;} = new List<Job>(); 

    public void Display()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine("List of Previous/Current Jobs:");

        foreach (Job job in jobs)
        {
            job.Display();
        }
    }

}