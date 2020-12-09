using System;
using Controllers;

namespace _2015
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if(args.Length > 0) {
                /*Type t = Type.GetType(args[0]);

                Console.WriteLine(t);

                var c = Activator.CreateInstance(t);*/

                switch(args[0]) {
                    case "day1":
                        Day1.Run();
                        break;                
                    case "day2":
                        Day2.Run();
                        break;                
                }
            } else {
                Console.WriteLine("Missing arguments");
            }
        }
    }
}