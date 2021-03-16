using System;

namespace heist2
{
    public class Hacker : IRobber
    {
        // ---- IRobber interface ----
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            Console.WriteLine($"{Name} is hacking the alarm system. Decreased security {SkillLevel} points.");
            bank.AlarmScore -= SkillLevel;
            if (bank.AlarmScore >= 0)
            {
                Console.WriteLine($"{Name} has disabled the alarm system!");
            }
        }
        // ---------------------------
    }
}