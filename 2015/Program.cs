using System;
using Controllers;

namespace _2015
{
    public class Program
    {
        public static void Main(string[] args)
        {
            switch(args[0]) {
                case "day1": {
                    Day1.Run();
                    break;
                }
            }
        }
    }
}
