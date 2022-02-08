using System;

namespace SimpSimulator.Models
{
    public interface IStreamer : IEmployee
    {
        public new void Work() {
            Console.WriteLine("This person is working");
        }
        protected new void RequestVacation()
        {
            Console.WriteLine("This person will take vacations");
        }
    }
}
