using System;

namespace SimpSimulator.Models
{
    public class Fanclub
    {
        public Fanclub(GamerGirl? queen, String name, double entryToll, double monthlyToll) {
            this.queen = queen;
            this.name = name;
            this.members = new();
            this.entryToll = entryToll;
            this.monthlyToll = monthlyToll;
        }
        public GamerGirl queen { get; set; }

        public String name { get; set; }

        private System.Collections.Generic.List<Simp> members { get; set; }

        public double entryToll { get; set; }

        public double monthlyToll { get; set; }

        public static void produceCringe() =>  Console.WriteLine("esta bien que nuestras novias y esposas quieran tener onlyfans, te hace sentir inseguro que sea mas exitosa que tu?, machirulo necesitas deconstruirte");

        private void extractMoneyFromSimps() => Console.WriteLine("pay up losers- I- I mean... uwu i need money to pay rent unu  and also a cute bf... maybe you? ugu");
    }
}
