using System;

public class PromptGenerator
{
    // list of journal prompts
    public List<string> _prompts = new List<string>
            {
            "What was the best thing that happened today?",
            "What was the worst thing that happened today?",
            "What was the most interesting thing I saw or heard today?",
            "What was the most challenging thing I faced today?",
            "What was the most fun thing I did today?",
            "What was the most surprising thing that happened today?",
            "What did I do today that I am proud of?"
            };
    
    // display randomly selected prompt
    public string Display()
    {
        // get and display random prompt
        Random R = new Random();
        int number = R.Next(0, _prompts.Count());
        return _prompts.ElementAt(number);
    }
}
