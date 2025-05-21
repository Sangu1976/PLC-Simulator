using System;

namespace MotorSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool motorRunning = false; // Motor is initially off

            Console.WriteLine("PLC Motor Simulator");
            Console.WriteLine("Commands: start, stop, status, exit");

            while (true)
            {
                Console.Write("> ");
                string input = Console.ReadLine()?.Trim().ToLower();

                if (input == "start")
                {
                    if (motorRunning)
                    {
                        Console.WriteLine("Motor already started/running.");
                    }
                    else
                    {
                        motorRunning = true; // Correctly update state
                        Console.WriteLine("Motor started.");
                    }
                }
                else if (input == "stop")
                {
                    if (!motorRunning)
                    {
                        Console.WriteLine("Motor already stopped.");
                    }
                    else
                    {
                        motorRunning = false; // Correctly update state
                        Console.WriteLine("Motor stopped.");
                    }
                }
                else if (input == "status")
                {
                    Console.WriteLine("Motor Status : " + (motorRunning ? "Running" : "Stopped"));
                }
                else if (input == "exit")
                {
                    Console.WriteLine("Exiting simulator...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid command. Use: start, stop, status, exit");
                }
            }
        }
    }
}
