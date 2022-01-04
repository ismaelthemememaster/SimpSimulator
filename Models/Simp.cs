using System;

namespace SimpSimulator.Models
{
    public class Simp
    {
        public Simp(string name, int lvl, int moneyLeft) {
            this.simpName = name;
            this.simpLvl = lvl;
            this.simpMoneyLeft = moneyLeft;
        }

        public string simpName { get; set; }

        public int simpLvl { get; set; }

        public int simpMoneyLeft { get; set; }

        public string notes { get { return notes; } set { notes = notes + value; } }
    }
}
