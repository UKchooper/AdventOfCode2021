using System;

namespace DayTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\carl.hooper\Desktop\InputDirections.txt");

            Console.WriteLine($"First answer is: {FirstTask(lines)}");
            Console.WriteLine($"Second answer is: {SecondTask(lines)}");
        }

        static int FirstTask(string[] input)
        {
            int forward = 0;
            int depth = 0;

            foreach (var eachInput in input)
            {
                string[] coordinates = eachInput.Split(' ');

                string movement = coordinates[0];
                int value = Int32.Parse(coordinates[1]);

                switch (movement)
                {
                    case "forward":
                        forward += value;
                        break;
                    case "up":
                        depth -= value;
                        break;
                    case "down":
                        depth += value;
                        break;
                }
            }

            return forward * depth;
        }

        static int SecondTask(string[] input)
        {
            int forward = 0;
            int depth = 0;
            int aim = 0;

            foreach (var eachInput in input)
            {
                string[] coordinates = eachInput.Split(' ');

                string movement = coordinates[0];
                int value = Int32.Parse(coordinates[1]);

                int tempForward = 0;

                switch (movement)
                {
                    case "forward":
                        forward += value;
                        tempForward += value;
                        break;
                    case "up":
                        aim -= value;
                        break;
                    case "down":
                        aim += value;
                        break;
                }

                depth += tempForward * aim;
            }

            return forward * depth;
        }
    }
}
