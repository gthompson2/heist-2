using System;

namespace heist2
{
    public class Bank
    {
        public int CashOnHand { get; set; }
        public int AlarmScore { get; set; }
        public int VaultScore { get; set; }
        public int SecurityGuardScore { get; set; }
        public Boolean isSecure
        {
            get
            {
                if ((CashOnHand + AlarmScore + VaultScore + SecurityGuardScore) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }


    }
}