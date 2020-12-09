using System.IO;
using System;
using System.Linq;

namespace Controllers
{
    public class Day2
    {
        public Day2() { }

        public static void Run() {
            var part1 = 0;
            var part2 = 0;
            
            foreach(var line in File.ReadLines("./inputs/day2.txt")) {
                part1 += Part1(line);
                part2 += Part2(line);
            }           
            
            Console.WriteLine($"2015 - Day 2 - Part 1 : {part1}");
            Console.WriteLine($"2015 - Day 2 - Part 2 : {part2}");
        }

        public static int Part1(string input) {
            var array = input.Split('x');
            var lower = int.MaxValue;
            var total = 0;
                        
            for(int i = 0; i < array.Length-1; i++) {
                for(int j = 1; j < array.Length; j++) {
                    if(j > i) {
                        var value = int.Parse(array[i])*int.Parse(array[j]);                        
                        total += value*2;
                        
                        if(value < lower) {
                            lower = value;
                        }
                    }
                }
            }
            
            total += lower;
            
            return total;
        }

        public static int Part2(string input) {
            var array = input.Split('x').Select(s => int.Parse(s)).ToArray();
            var total = array.Aggregate(1, (a, b) => a * b);
            var lower1 = int.MaxValue;
            var lower2 = int.MaxValue;
            
            for(int i = 0; i < array.Length; i++) {
                if(array[i] < lower1) {
                    if(lower1 < lower2) {
                        lower2 = lower1;
                    }
                    
                    lower1 = array[i];
                } else if (array[i] < lower2){
                    lower2 = array[i];                    
                }
            }
            
            total += lower1*2;
            total += lower2*2;
            
            return total;         
        }
    }
}