using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "International Comunication";
        job1._company = "World Trade Center";
        job1._startYear = 1973;
        job1._endYear = 2001;

        Job job2 = new Job();
        job2._jobTitle = "International Tourism Manager";
        job2._company = "World Trade Center";
        job2._startYear = 1978;
        job2._endYear = 2001;

        Resume myResume = new Resume();
        myResume._name = "Claire Yamasaki";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}