using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

namespace Advent_of_Code.Controllers
{
    public class Year2015 : IYear
    {
        private const string pathInputs = "./inputs/2015"; 

        public Year2015() { }

        public void Day1() {
            
        }

        #region Day 2

        public void Day2() {
            var part1 = 0;
            var part2 = 0;
            
            foreach(var line in File.ReadLines($"{pathInputs}/day2.txt")) {
                part1 += Day2Part1(line);
                part2 += Day2Part2(line);
            }           
            
            Console.WriteLine($"2015 - Day 2 - Part 1 : {part1}");
            Console.WriteLine($"2015 - Day 2 - Part 2 : {part2}");
        }    

        public static int Day2Part1(string input) {
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

        public static int Day2Part2(string input) {
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

        #endregion 
        
        #region Day 3

        public void Day3() {
            var part1 = 0;
            var part2 = 0;
            
            foreach(var line in File.ReadLines($"{pathInputs}/day3.txt")) {
                part1 += Day3Part1(line);
                part2 += Day3Part2(line);
            }           
            
            Console.WriteLine($"2015 - Day 3 - Part 1 : {part1}");
            Console.WriteLine($"2015 - Day 3 - Part 2 : {part2}");
        }

        public static int Day3Part1(string input) {
            var locationX = 0;
            var locationY = 0;
            var array = input.ToCharArray();
            var locationVisited = new List<string>();
            locationVisited.Add($"{locationX}/{locationY}");
                        
            for(int i = 0; i < array.Length; i++) {
                switch(array[i].ToString()) {
                    case "^":
                        locationY++;
                        break;
                    case "v":
                        locationY--;
                        break;
                    case ">":
                        locationX++;
                        break;
                    case "<":
                        locationX--;
                        break;
                }
                
                if(!locationVisited.Contains($"{locationX}/{locationY}")) {
                    locationVisited.Add($"{locationX}/{locationY}");
                }
            }
            
            return locationVisited.Count;
        }

        public static int Day3Part2(string input) {
            var array = input.ToCharArray();
            var locationX = 0;
            var locationY = 0;
            var locationXRobot = 0;
            var locationYRobot = 0;
            var locationVisited = new List<string>();
            locationVisited.Add($"{locationX}/{locationY}");
                        
            for(int i = 0; i < array.Length; i++) {
                if(i%2 == 0) {
                   switch(array[i].ToString()) {
                        case "^":
                            locationY++;
                            break;
                        case "v":
                            locationY--;
                            break;
                        case ">":
                            locationX++;
                            break;
                        case "<":
                            locationX--;
                            break;
                    }
                    
                    if(!locationVisited.Contains($"{locationX}/{locationY}")) {
                        locationVisited.Add($"{locationX}/{locationY}");
                    }
                } else {
                    switch(array[i].ToString()) {
                        case "^":
                            locationYRobot++;
                            break;
                        case "v":
                            locationYRobot--;
                            break;
                        case ">":
                            locationXRobot++;
                            break;
                        case "<":
                            locationXRobot--;
                            break;
                    }
                    
                    if(!locationVisited.Contains($"{locationXRobot}/{locationYRobot}")) {
                        locationVisited.Add($"{locationXRobot}/{locationYRobot}");
                    }
                }
            }
            
            return locationVisited.Count;      
        }

        #endregion

        public void Day4() {
            
        }
        public void Day5() {
            
        }
        public void Day6() {
            
        }
        public void Day7() {
            
        }
        public void Day8() {
            
        }
        public void Day9() {
            
        }
        public void Day10() {
            
        }
        public void Day11() {
            
        }
        public void Day12() {
            
        }
        public void Day13() {
            
        }
        public void Day14() {
            
        }
        public void Day15() {
            
        }
        public void Day16() {
            
        }
        public void Day17() {
            
        }
        public void Day18() {
            
        }
        public void Day19() {
            
        }
        public void Day20() {
            
        }
        public void Day21() {
            
        }
        public void Day22() {
            
        }
        public void Day23() {
            
        }
        public void Day24() {
            
        }
        public void Day25() {
            
        }
    }
}