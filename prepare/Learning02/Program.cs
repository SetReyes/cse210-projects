using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate First Job
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Instantiate Second Job
        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Instantiate Resume
        Resume myResume = new Resume();
        myResume._personName = "Allison Rose";

        // Add Job information to the job list in Resume Class
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Displace Resume list
        myResume.DisplayResume();
    }
}