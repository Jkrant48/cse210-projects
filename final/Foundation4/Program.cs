using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello This is the Exercise Tracker!\n");

        // activities
        Running running = new Running("24 Nov 2023", 120, "Running", 30);
        StationaryBicycle stationaryBicycle = new StationaryBicycle("30 Dec 2023", 300, "Stationary Bicycles", 60, 90);
        Swimming swimming = new Swimming("3 Aug 2023", 160, 15, "Swimming");

        var activities = new List<Activity>
        {
            swimming,
            running,
            stationaryBicycle
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }


        
    }
}