// See https://aka.ms/new-console-template for more information
//int[] A = new int[] { 1, 3, 6, 4, 1, 2 };

//Console.Write(solution(A));
//BinaryGap(100);
//int[] A = new int[] { 3, 8, 9, 7, 6 };
//ArrayRotation(A, 3);

//int[] A = new int[] { 9, 3, 9, 3, 9, 7, 9 };
//OddOccuranceINArray(A);

//FrogJumb(10, 90, 30);
using System.Diagnostics;

int[] A = new int[] { -1000, 1000 };
//TapeEquilibrium(A);


var myArray = ProblemSolving.Solutions.Algorithems.GenerateRandomArray();

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

//Summ(myArray);

//Sum(new int[] { -1000, 1000});
// Console.WriteLine(PassingCars(new int[] {0,1,0,1,1 }));
// repeatingChar("hellooaa");
// MaximumWordCount("Forget  CVs..Save time . x x");
//Console.WriteLine(PascalTriangle(80));
//ParseRomanNumerals("MCMLXI");
//jumpingOnClouds(new int[] { 0,0,1,0,0,1,0});
//Algorithems.repeatedString("kmretasscityylpdhuwjirnqimlkcgxubxmsxpypgzxtenweirknjtasxtvxemtwxuarabssvqdnktqadhyktagjxoanknhgilnm", 736778906400);
// Algorithems.PlusOne_MySolution(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });
//Algorithems.DistributeCandies(new int[] {6,6,6,6 });
//Algorithems.minimumBribes(new System.Collections.Generic.List<int> { 2,1,5,3,4 });
// Algorithems.CanConstruct("aa", "aab");
//Algorithems.ClimbStairs(5);
//Algorithems.IsPalindrome("A man, a plan, a canal: Panama");
//Algorithems.SingleNumber_III(new int[] { 1, 2, 1, 3, 2, 5 });
ProblemSolving.Solutions.Algorithems.Average(2, 1);
stopwatch.Stop();

Console.WriteLine(stopwatch.ElapsedMilliseconds);
Console.ReadLine();
