using System;

namespace SimpSimulator.Models
{
    public static class Twitch
    {
        public static int viewers { get; set; }
        static Twitch() {
            viewers = 0;
        }

        private static System.Collections.Generic.List<GamerGirl> shadowBanList = new();

        private static void ruinCareer(GamerGirl heretic) {
            Console.WriteLine($"La hereje {heretic.name} ha dicho que Taiwan es un pais, sera relegada al reino de las sombras");
            shadowBanList.Add(heretic);
        }

        private static void hailXiJinping()
        {
            Console.WriteLine("Alabado sea el gran lider Xi Jinping, que nos da la oportunidad de adorarlo");
        }

        private static void newAdpocalypse()
        {
            //TO DO: bajarle el sueldo a todos supongo   :v
        }

    }
}
