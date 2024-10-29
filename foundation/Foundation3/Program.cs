using System;
using System.Collections.Generic;

public class Activity
{
    private DateTime date;
    private int duration;

    public Activity(DateTime date, int duration)
    {
        this.date = date;
        this.duration = duration;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{date:dd MMM yyyy} Activity ({duration} min)";
    }
}

public class Running : Activity
{
    private double distance; 

    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return (distance / duration) * 60;
    }

    public override double GetPace()
    {
        return duration / distance; 
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace():0.00} min per mile";
    }
}

public class Cycling : Activity
{
    private double speed; // in mph

    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return (speed * duration) / 60; 
    }

    public override double GetSpeed()
    {
        return speed; 
    }

    public override double GetPace()
    {
        return 60 / speed; 
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace():0.00} min per mile";
    }
}

public class Swimming : Activity
{
    private int laps; 

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return (laps * 50) / 1000.0; 
    }

    public override double GetSpeed()
    {
        return (GetDistance() / duration) * 60; 
    }

    public override double GetPace()
    {
        return duration / GetDistance(); 
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance():0.00} km, Speed: {GetSpeed():0.00} kph, Pace: {GetPace():0.00} min per km";
    }
}

public class Program
{
    public static void Main(string[] args)
    {

        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 3.0),
            new Cycling(new DateTime(2022, 11, 4), 45, 12.0),
            new Swimming(new DateTime(2022, 11, 5), 25, 20)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}