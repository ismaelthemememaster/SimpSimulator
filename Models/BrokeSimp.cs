using System;

namespace SimpSimulator.Models
{
    public class BrokeSimp : Thirsty
    {
        public BrokeSimp(decimal debt, ushort thirstLevel, string personality= "beta") : base (thirstLevel, lastGirlfriend: DateTime.Today ,personality: personality) {
            
            this.debt = debt;

            //iniciar el job y dict
        }
        private decimal debt;

        private void whiteKnight() {
            Console.WriteLine("DO NOT FRET M'LADY, YOU ARE NOT CRINGE, FOR I FOLLOW YOU AND I AM NOT THY CRINGE");
        }

        public void contemplateDebt()
        {
            Console.WriteLine("-the poor simp sees his debt rise: oh, it has gone up to ", debt, " dollars!");
        }

        public void beIrrelevantToSociety()
        {
            Console.WriteLine("I identify with Aqua from Konosuba, she is actually so useful!!");
        }

        //TO DO, needs a job, same as simp, and the DICT

    }
}
