using System;

namespace heist2
{
    public class LockSpecialist : IRobber
    {
        // ---- IRobber interface ----
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            Console.WriteLine($"{Name} is cracking the vault. Decreased lock integrity by {SkillLevel} points.");
            bank.VaultScore -= SkillLevel;
            if (bank.VaultScore >= 0)
            {
                Console.WriteLine($"{Name} has opened the vault!");
            }
        }
        // ---------------------------
    }
}