using System;
using System.Collections.Generic;

public class DailyQuote
{
    public List<string> _dailyQuote = new List<string>(){
        "Think Celestial - Russel M. Nelson",
        "I promise your personal anguish will be relieved and your obedience and faithfulness to patiently submit your will to God will be rewarded in the own due time of the Lord. - David A Bednar",
        "I have learned from personal experience that spiritual preparation for the coming for the Lord is not only essential, but the only way to find true peace and happiness. - Amy A. Wright",
        "Covenants are the shape of God's embrace. - Robert M. Daines",
        "Just as yesterday's decisions impact today's realities, decisions of today will impact our future and the future of our family members. - Carlos A. Godoy",
        "Despite our every effort, you and I won't heal everyone, but each of us can be the one who can make a difference for good in the life of someone. - Ian S. Arden",
        "I testify that the atonement of Jesus Christ has made immortality a verity and the possibility of exhalted family relationships a reality. - D. Todd Christofferson",
        "The final judgment is not just an evaluation of the sum total of good and evil acts, what we have done. It is based on the final effect of our acts and thoughts, what we have become. - Dallin H. Oaks",
        "All is known by the Lord and, in time, we will see all His sacred purposes fulfilled. - Neil L. Andersen",
        "Jesus is not a Sunday-only topic. - Jan E. Newman",
        "We don't come to Jesus because we are perfect. We come to Him because we are flawed and, in Him, we can be perfected. - Joaquin E. Costa",
        "If you hope to feel the Spirit, be in a place where the Spirit can easily dwell. - Gary E. Stevenson",
        "Do you want to be happy? Stay on the covenant path. Your life will be easier, happier, and filled with joy. - Yoon Hwan Choi",
        
    
    };
    
    public string GetRandomQuote()
    {
        Random r = new Random();
        int rInt = r.Next(0, _dailyQuote.Count);

        return _dailyQuote[rInt];
    }
}