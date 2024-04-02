using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        // lecture creation
        Address lectureAddress = new Address("101 E Viking St.", "Rexburg", "Idaho", "USA");
        Lecture lecture = new Lecture("Brother Thayne's Love for Web Development", "Brother Thayne talks about his love for web development", "4/4/2024", "12:45 pm", lectureAddress, "Tim Thayne", 25);

        // lecture info displays
        Console.WriteLine("Lecture Information:");
        Console.WriteLine(); // blank line
        Console.WriteLine("Standard Details:");
        lecture.StandardDetails();
        Console.WriteLine(); // blank line
        Console.WriteLine("Full Details:");
        lecture.LectureFullDetails();
        Console.WriteLine(); // blank line
        Console.WriteLine("Short Description:");
        lecture.LectureShortDescription();

        Console.WriteLine("----------------------------------------------------------------------------------------------------"); // buffer line

        // reception creation
        Address receptionAddress = new Address("64 E 7th S", "Rexburg", "Idaho", "USA");
        Reception reception = new Reception("Gathering of Married Students", "married students are welcome to gather and mingle together", "4/1/2024", "6:45 pm", receptionAddress, "example@byui.edu");

        // reception info displays
        Console.WriteLine("Reception Information:");
        Console.WriteLine(); // blank line
        Console.WriteLine("Standard Details:");
        reception.StandardDetails();
        Console.WriteLine(); // blank line
        Console.WriteLine("Full Details:");
        reception.ReceptionFullDetails();
        Console.WriteLine(); // blank line
        Console.WriteLine("Short Description:");
        reception.ReceptionShortDescription();

        Console.WriteLine("----------------------------------------------------------------------------------------------------"); // buffer line

        // outdoor gathering creation
        Address outdoorAddress = new Address("E Main St.", "Rexburg", "Idaho", "USA");
        Outdoor outdoor = new Outdoor("Smith Park Boogaloo", "an outdoor gathering at Smith Park", "2/3/2024", "12:00 pm", outdoorAddress, "sunny");

        // outdoor gathering info displays
        Console.WriteLine("Outdoor Gathering Information:");
        Console.WriteLine(); // blank line
        Console.WriteLine("Standard Details:");
        outdoor.StandardDetails();
        Console.WriteLine(); // blank line
        Console.WriteLine("Full Details:");
        outdoor.OutdoorFullDetails();
        Console.WriteLine(); // blank line
        Console.WriteLine("Short Description:");
        outdoor.OutdoorShortDescription();
    }
}