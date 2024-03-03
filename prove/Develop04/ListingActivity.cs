using System;

class ListingActivity : Activity
{
    // attributes
    private List<string> _listingQuestions = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private int _goodThings = 0;

    // constructor
    public ListingActivity(string name, string description) : base(name, description)
    {
        
    }

    // display randomly selected question
    public void DisplayListingQuestion()
    {
        Random R = new Random();
        int number = R.Next(0, _listingQuestions.Count());
        Console.WriteLine($"--- {_listingQuestions.ElementAt(number)} ---");
    }

    // run the listing activity
    public void RunListingActivity()
    {
        // get duration
        int duration = GetDuration();

        // activity instructions
        Console.WriteLine("List as many responses as you can to the following prompt:");
        DisplayListingQuestion();
        Console.Write("You may begin in: ");
        CountdownPause(5);
        Console.WriteLine(); // next line

        // find the time when the activity should end
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        // begin activity
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine(); // wait for user to hit enter after typing response
            _goodThings += 1; // add 1 to the count of good things listed
        }

        // end of activity item count
        Console.WriteLine($"You listed {_goodThings} items!");
        Console.WriteLine(); // blank line
    }
}