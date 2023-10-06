using System;
using System.Collections.Generic;

public class Prompt
{
    public List<string> _questions = new List<string>(){
        "What was the highlight of your day?",
        "What is something you're grateful for today?",
        "What challenges did you face today?",
        "How did you overcome those challenges?",
        "What made you smile today?",
        "Describe a moment when you felt proud of yourself.",
        "What was the most important task you accomplished today?",
        "What's a goal you're working towards, and how did you progress today?",
        "What did you learn today, whether big or small?",
        "Did you have any meaningful conversations today? If so, what were they about?",
        "How did you take care of your physical health today?",
        "What did you do for your mental well-being today?",
        "What's something that inspired or motivated you today?",
        "Did you experience any moments of joy today? Describe them.",
        "What are your top priorities for tomorrow?",
        "Is there anything you'd like to improve or change about your day?",
        "How did you manage your time today?",
        "Were there any unexpected surprises today, good or bad?",
        "What's something you're looking forward to in the near future?",
        "What's a small act of kindness you did for someone or someone did for you today?",
        "How did you handle stress or anxiety today?",
        "Describe a moment when you felt peaceful or content.",
        "What's a new idea or concept you explored or thought about today?",
        "Did you make any progress toward a long-term goal or dream?",
        "How did you practice self-care today?",
        "Did you try something new or step out of your comfort zone today?",
        "How did you contribute to your personal growth or self-improvement today?",
        "What's a decision you made today, and how did it impact your day?",
        "How did you show appreciation to someone today?",
        "What's a book, article, or quote that resonated with you today?",
        "How did you manage your emotions today?",
        "Did you have any creative or artistic moments today?",
        "What's a challenge you'd like to tackle in the near future?",
        "What's something that made you laugh today?",
        "How did you connect with nature today, if at all?",
        "Did you experience any setbacks today? How will you bounce back?",
        "What's a skill or talent you're proud of, and how did you use it today?",
        "What's a project or task you're excited about working on?",
        "How did you maintain a healthy work-life balance today?",
        "What's one thing you'd like to remember about today in the future?"

    };
    
    public string GetRandomQuestion()
    {
        Random r = new Random();
        int rInt = r.Next(0, _questions.Count);
        //It will select randomly one of the questions based on their index and considering the //
        // quantity of questions on my list. The _questions.Count assures that, in case there are //
        // changes to my list, the length will be considered in total.//

        return _questions[rInt];
    }
}


