using System;
using System.Collections.Generic;


public class PromptGen
{
    public List<string> _Prompts;
 
    public PromptGen()
    {
        _Prompts = new List<string>()
        {
            "What would you like to do?",
            "If i had one thing i could do over today, what would it be?",
            "What was the best part of my day?"
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_Prompts.Count);
        return _Prompts[index];     
    }
}