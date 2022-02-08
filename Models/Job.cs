using System;

namespace SimpSimulator.Models
{
    public class Job<String, T1, T2>
    {
        public Job(string jobName, T1 Tincome, T2 Ttime) {
            this.jobName = jobName;
            this.Tincome = Tincome;
            this.Ttime = Ttime;
        }
        private string jobName { get; set; }

        private T1 Tincome { get; set; }

        private T2 Ttime { get; set; }

        public void produceMoney() =>  Console.WriteLine("aaaaaaaaa");

        private void LooseMoney() => Console.WriteLine("aaaaaa");
    }
}
