using System;

// new Resume class
public class Resume
{
    // resume info
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    // print resume info
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // print jobs
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}