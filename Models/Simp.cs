using System;

namespace SimpSimulator.Models
{
    public class Simp : Thirsty, IEmployee
    {
        public Simp(string name, uint simpLevel, double moneyLeft, string personality, ushort thirstLevel, DateTime lastGirlfriend) : base( thirstLevel, lastGirlfriend = DateTime.Now, personality = "beta") {
            this.simpName = name;
            this.simpLevel = simpLevel;
            this.simpMoneyLeft = moneyLeft;
            var dict = new Dict<Fanclub, uint>();

        }
        public string simpName { get; private set; }

        public uint simpLevel { get; private set; }

        public double simpMoneyLeft { get; set; }

        public string notes { get { return notes; } private set { notes = notes + value; } }

        //public Dict<Fanclub, uint> Dict;

        public void ReduceMoney(double toll) {
            this.simpMoneyLeft = this.simpMoneyLeft - toll;
        }
        public void AddNote(string note)
        {
            this.notes = this.notes = note;
        }
        public void SimpFor(GamerGirl girl)
        {
            Console.WriteLine($"My queen {girl.name} is the best, i will pay for her vacations... our vacations  uwu");
        }

        public void Work()    //parece que hay que implementarlo si o si publico
        {
            Console.WriteLine($"I {this.simpName}, will work to buy feet pics or used bathwater");
        }

        private void Work(GamerGirl girl)
        {
            Console.WriteLine($"I {this.simpName}, will give my money to {girl.name} of course, that way it feels like i have a gf");
        }
    }
}
