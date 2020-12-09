using System.Reflection;
using System;

namespace _
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if(args.Length == 2) {
                Type t = Type.GetType($"Advent_of_Code.Controllers.{args[0]}");

                if(t != null) {
                    var controller = Activator.CreateInstance(t);
                    MethodInfo theMethod = t.GetMethod(args[1]);

                    theMethod.Invoke(controller, null);
                } else {
                    Console.WriteLine("Unknown day");
                }                
            } else {
                Console.WriteLine("Missing arguments");
            }
        }
    }
}