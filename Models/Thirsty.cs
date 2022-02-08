using System;

namespace SimpSimulator.Models
{
    public abstract class Thirsty
    {
        public Thirsty(ushort lvl, DateTime lastGirlfriend, string personality = "beta") {
            this.personality = personality;
            this.thirstLevel = lvl;
            this.lastGirlfriend = lastGirlfriend;
        }
        public string personality { get; }

        public ushort thirstLevel { get; set; }

        private readonly DateTime lastGirlfriend;

        private void harass(in GamerGirl gamergirl) {
            Console.WriteLine($"{gamergirl.name} is so cringe and on top of that she is {gamergirl.is3D}, peak cringe");
        }

        private void whiteKnight(in GamerGirl gamergirl)
        {
            Console.WriteLine($"{gamergirl.name} is NOT cringe, YOU are cringe");
        }

        private void askForNudes(in GamerGirl gamergirl)
        {
            Console.WriteLine($"hey {gamergirl.name}, my queen...I just had to notice your fat boobies, not that there's anything wrong with that *tips fedora*, I would like to examine them close so if you would bless me with a picture of them I'd be my honor *tips harder*");
        }

    }
}
