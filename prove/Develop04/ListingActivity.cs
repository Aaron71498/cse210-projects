using System;

class ListingActivity : Activity
{
    // attributes
    private string _listingName = "Listing Activity";
    private string _listingDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    private List<string> _listingQuestions = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List<string> _goodThings = new List<string>();

    // constructor
    public ListingActivity(string name, string description) : base(name, description)
    {
        
    }

    // methods
    public string GetListingName()
    {
        return _listingName;
    }

    public string GetListingDescription()
    {
        return _listingDescription;
    }

    // display randomly selected question
    public void DisplayListingQuestion()
    {
        Random R = new Random();
        int number = R.Next(0, _listingQuestions.Count());
        Console.WriteLine(_listingQuestions.ElementAt(number));
    }
}