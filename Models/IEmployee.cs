using System;

namespace SimpSimulator.Models
{
    public interface IEmployee
    {
        void Work();
        protected void RequestVacation()
        {
            Console.WriteLine("This person will take vacations");
        }
    }
}
