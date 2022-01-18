using System;

namespace SimpSimulator.Models
{
    public class Thirsty
    {
        public Thirsty(string personality, ushort lvl, DateTime lastGirlfriend) {
            this.personality = personality;
            this.thirstLevel = lvl;
            this.lastGirlfriend = lastGirlfriend;
        }
        public readonly string personality = "beta";

        public ushort thirstLevel { get; set; }

        private readonly DateTime lastGirlfriend;

        private void harass(GamerGirl gamergirl) {
            Console.WriteLine("gamergirl.getGamerName() is so cringe and on top of that she is $gamergirl.is3D");
        }

        private void whiteKnight(GamerGirl gamergirl)
        {
            Console.WriteLine("gamergirl.getGamerName() is NOT cringe, YOU are cringe");
        }

        private void askForNudes(GamerGirl gamergirl)
        {
            Console.WriteLine("hey queen, I just had to notice your fat boobies, not that there's anything wrong with that *tips fedora*, I would like to examine them close so if you would bless me with a picture of them I'd be my honor *tops harder*");
        }

    }
}
