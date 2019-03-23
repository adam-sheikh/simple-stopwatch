using System;
using System.Threading;

namespace Classes
{

    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new StopWatch();
            string command;

            Console.WriteLine("type 'start', 'stop' or 'quit'");
            command = Console.ReadLine().ToLower();

            while(command != "quit")
            {
                command = command.ToLower();
                if (command == "start")
                {
                    stopWatch.Start();
                    command = Console.ReadLine().ToLower();
                }
                else if (command == "stop")
                {
                    stopWatch.Stop();
                    command = Console.ReadLine().ToLower();
                }
                else if (command == "pause")
                {
                    stopWatch.Pause();
                    command = Console.ReadLine().ToLower();
                }
                else if (command == "resume")
                {
                    stopWatch.Resume();
                    command = Console.ReadLine().ToLower();
                }
                else
                {
                    Console.WriteLine("invalid command. Please type 'start', 'stop' or 'quit'");
                    command = Console.ReadLine().ToLower();
                }
            }
        }
    }
}
