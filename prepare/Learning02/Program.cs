using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Console.WriteLine("Hello World");

        job job1 = new job();
        job1._company = "Google";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2023;

        job job2 = new job();
        job2._company = "Facebook";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2013;
        job2._endYear = 2019;

        job1.DisplayJobDetails();
        job2.DisplayJobDetails();

        resume resume1 = new resume();
        resume1._name = "Angel Manzano";

        resume1.DisplayJobList();
    }

    

}