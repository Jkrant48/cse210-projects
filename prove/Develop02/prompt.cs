using System;
using System.Collections.Generic;
//this class contains a list of prompts that 
// will be displayed randomly

public class PromptGenerator{

    public List<string> _prompts = new List<string>{
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?"
    };

    public string displayPrompt(){
        Random random = new Random();
        int randomNum = random.Next(_prompts.Count);

        string randomPrompt = _prompts[randomNum];
        return randomPrompt;
    }
}