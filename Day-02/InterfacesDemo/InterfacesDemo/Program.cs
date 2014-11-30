using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayCricket[] team = new IPlayCricket[3];
            team[0] = new SoftwareDeveloper(){ Name = "Magesh"};
            team[1] = new Manager(){Name = "Suresh"};
            team[2] = new SoftwareDeveloper(){Name = "Ganesh"};

            for(var i=0;i<team.Length;i++)
                team[i].Play();

            Console.ReadLine();
        }
    }

    public interface IPlayCricket
    {
        void Play();
    }

    public class SoftwareDeveloper : IPlayCricket
    {
        public string Name { get; set; }

        public void Play()
        {
            Console.WriteLine("{0} - a software engineer is playing cricket", this.Name);
        }
    }

    public class Manager : IPlayCricket
    {
        public string Name { get; set; }

        public void Play()
        {
            Console.WriteLine("{0} - a manager is playing cricket", this.Name);
        }
    }
}
