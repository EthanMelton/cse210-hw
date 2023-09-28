using System;

class Program
{
    static void Main(string[] args)
    {
        Job FirstJob = new Job();
        FirstJob.JobTitle = "Data Analyst";
        FirstJob.Company = "Google";
        FirstJob.StartYear = 2003;
        FirstJob.EndYear = 2018;
        
        Job SecondJob = new Job();
        SecondJob.JobTitle = "Software Engineer";
        SecondJob.Company = "Microsoft";
        SecondJob.StartYear = 2019;
        SecondJob.EndYear = 2022;

        Job ThirdJob = new Job();
        ThirdJob.JobTitle = "Manager";
        ThirdJob.Company = "Apple";
        ThirdJob.StartYear = 2022;
        ThirdJob.EndYear = 2023;

        Job FourthJob = new Job();
        FourthJob.JobTitle = "Data Scientist";
        FourthJob.Company = "Apple";
        FourthJob.StartYear = 2018;
        FourthJob.EndYear = 2023;

        Resume FirstResume = new Resume();
        FirstResume.name = "Allison Rose";

        Resume SecondResume = new Resume();
        SecondResume.name = "Steven Harvey";

        FirstResume.jobs.Add(SecondJob);
        FirstResume.jobs.Add(ThirdJob);
        SecondResume.jobs.Add(FirstJob);
        SecondResume.jobs.Add(FourthJob);

        Console.WriteLine();
        FirstResume.Display();
        Console.WriteLine();
        SecondResume.Display();
        Console.WriteLine();
    }
}