using System;

class Program
{
    static void Main(string[] args)
    {
        // list of activities
        List<Activity> activities = new List<Activity>();

        // create running activity and add to list
        Running running = new Running("04 Apr 2024", 30, 3);
        activities.Add(running);

        // create biking activity and add to list
        Bicycles bicycles = new Bicycles("02 Feb 2022", 45, 25);
        activities.Add(bicycles);

        // creat swimming activity and add to list
        Swimming swimming = new Swimming("03 March 2023", 25, 25);
        activities.Add(swimming);

        // print summary from each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.Summary());
        }
    }
}