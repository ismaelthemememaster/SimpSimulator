using System;

namespace SimpSimulator.Models
{
    public class GamerGirl : Person, IStreamer, IEmployee
    {
        public GamerGirl(string name, bool is3D, DateTime birthDate, string gender) : base(name, birthDate, gender) {
            this.name = name;
            this.is3D = is3D;
            this.gender = gender;
        }
        public override string name { get; }

        public bool is3D { get; set; }

        public override string gender { get; }

        public void Work()    //parece que hay que implementarlo si o si publico
        {
            Console.WriteLine($"I will sell all these simps some water i washed my hands on, making them think it's my used bathwater");
        }

    }
}
