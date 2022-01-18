using System;

namespace SimpSimulator.Models
{
    public class Simp : Thirsty
    {
        public Simp(string name, int lvl, int moneyLeft, string personality) {
            this.simpName = name;
            this.simpLevel = lvl;
            this.simpMoneyLeft = moneyLeft;
        }
        public string simpName { get; set; }

        public int simpLevel { get; set; }

        public int simpMoneyLeft { get; set; }

        public string notes { get { return notes; } set { notes = notes + value; } }
    }
}
