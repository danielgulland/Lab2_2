using System;

namespace Lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which health plan would you like to choose?");
            var choice = Console.ReadLine();
            var plan = HealthPlanFactory.SelectHealthPlan(choice);
            if(plan == null)
            {
                Console.WriteLine("No such health plan exists.");
            }
            else
            {
                Console.WriteLine(plan);
            }
        }
    }
}
