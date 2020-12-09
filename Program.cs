using System.Reflection;
using System;

namespace _
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter year and day (ex: Year2015 Day1) : ");
		    var parameters = Console.ReadLine().Split(" ");

            if(parameters.Length == 2) {
                Type t = Type.GetType($"Advent_of_Code.Controllers.{parameters[0]}");

                if(t != null) {
                    var controller = Activator.CreateInstance(t);
                    MethodInfo theMethod = t.GetMethod(parameters[1]);

                    if(theMethod != null) {
                        theMethod.Invoke(controller, null);
                    } else {
                        Console.WriteLine("ERR: Unknown day");
                    }
                } else {
                    Console.WriteLine("ERR: Unknown year");
                }                
            } else {
                Console.WriteLine("ERR: Missing parameters");
            }
        }
    }
}