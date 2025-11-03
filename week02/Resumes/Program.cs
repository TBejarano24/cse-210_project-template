using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new();

        job1._jobTitle = "Software Engineer";
        job1._company = "Real Company";
        job1._startYear = 2020;
        job1._endYear = 2024;

        Job job2 = new();

        job2._jobTitle = "Data Tester";
        job2._company = "False Company";
        job2._startYear = 2019;
        job2._endYear = 2020;

        Resume myResume = new();

        myResume._name = "Tomas Bejarano";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();
    }
}