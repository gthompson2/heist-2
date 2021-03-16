using System;

namespace heist2
{
    public class Msucle : IRobber
    {
        // ---- IRobber interface ----
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            Console.WriteLine($"{Name} is handling the security guards. Decreased security {SkillLevel} points.");
            bank.SecurityGuardScore -= SkillLevel;
            if (bank.SecurityGuardScore >= 0)
            {
                Console.WriteLine($"{Name} has disabled the security guards!");
            }
        }
        // ---------------------------
    }
}