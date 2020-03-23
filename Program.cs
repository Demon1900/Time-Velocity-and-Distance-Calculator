using System;

namespace Time_Velocity_Distance_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Double Time;
            Double Velocity;
            Double Distance;
            Double Total;
            String picker;
            String Repeat;
            
                Console.WriteLine("Welcome to the Time Velocity Distance calculator");
            do
            {
                Console.WriteLine("\nWhat are you trying to calculate?\nTime,Velocity, or Distance");

                picker =Console.ReadLine();
                switch (picker)
                {
                    case "Time":
                    case "time":
                    Console.WriteLine("Enter the velocity.");
                        Velocity=Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter the Distance.");
                        Distance = Convert.ToDouble(Console.ReadLine());

                        Total = Distance / Velocity;
                        Console.WriteLine("The Time is " + Total);
                    break;
                    case "Velocity":
                    case "velocity":
                        Console.WriteLine("Enter the time.");
                        Time = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter the Distance.");
                        Distance = Convert.ToDouble(Console.ReadLine());

                        Total = Distance / Time;
                        Console.WriteLine("The velocity is " + Total);
                        break;

                    case "Distance":
                    case "distance":
                        Console.WriteLine("Enter the Time.");
                        Time = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter the velocity.");
                        Velocity = Convert.ToDouble(Console.ReadLine());

                        Total = Time * Velocity;
                        Console.WriteLine("The distance is " + Total);
                        break;
                    default:
                        Console.WriteLine("What you enter is not vaild");
                        break; 
                }

                Console.WriteLine("\nDo you want to try again.");
                 Repeat = Console.ReadLine();
            } while (Repeat.Equals("Yes") || Repeat.Equals("yes"));
            
        }
    }
}
