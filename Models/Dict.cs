using System;
using System.Collections.Generic;

namespace SimpSimulator.Models
{
    public class Dict<Ttype, Tlevel>
    {
        //Type A = typeof(T1<int, int>);
        public Dict() {
            this.objectOfAdoration = new List<Ttype>();
            this.levelOfPatheticness = new List<Tlevel>();
        }
        private List<Ttype> objectOfAdoration;

        private List<Tlevel> levelOfPatheticness;


        public void Simp(Ttype idol, Tlevel level) {
            objectOfAdoration.Add(idol);
            levelOfPatheticness.Add(level);
        }

        public void ShowLoyalties()
        {
            foreach (Ttype idol in objectOfAdoration)
            {
                Console.WriteLine($"I serve {idol.ToString()}");
            }
        }

    }
}
