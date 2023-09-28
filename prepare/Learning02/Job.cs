using System;

public class Job
{
    public string company;
    public string JobTitle;
    public int StartYear;
    public int EndYear;

    public void Display()
    {
        Console.WriteLine($"{JobTitle} ({company}) {StartYear}-{EndYear}");
    }
}