using System;
using System.Collections.Generic;
using System.Text;

namespace SimpSimulator.Models
{
    public class Dict<Ttype, Tlevel> where Ttype : GamerGirl
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

        public string ShowLoyalties()
        {
            StringBuilder buffer = new StringBuilder("");

            if (objectOfAdoration.Count == 0) {
                return "I serve no one";
            }
            else {
                buffer.Append("I serve");
                foreach (Ttype idol in objectOfAdoration)
                {
                    buffer.Append(" {idol.name},");
                }
                return buffer.ToString();
            }
        }

        public string AskLoyalty(Ttype idol)
        {
            var index = objectOfAdoration.IndexOf(idol);
            if (index > -1)
            {
                return ($"{idol.name} you say?, I've never heard of that normie, does she do feet pics?");
            }
            else {
                return ($"Yes, I serve {idol.name}, I simp for her {levelOfPatheticness[index]} times a day");
            }
        }

    }
}
