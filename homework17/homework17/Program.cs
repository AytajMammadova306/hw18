﻿using homework17.Models;

namespace homework17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pair<int, string> pair = new Pair<int, string>
            {
                Key=1,
                Value="samebody"
            };
            Pair<int, int> pair2 = new Pair<int, int>
            {
                Key = 2,
                Value = 102
            };
            Pair<int, int> pair3 = new Pair<int, int>
            {
                Key = 3,
                Value = 103
            };
            Pair<int, string>.Add(pair);
            Pair<int, int>.Add(pair2);
            Pair<int, int>.Add(pair3);
            Pair<int,string>.PrintInfo();
            Pair<int, int>.PrintInfo();

            //Console.WriteLine(pair2[1]);
            //exception verecey hal

            Console.WriteLine("------------------");
            Pair<string, int> pair4 = new Pair<string, int>
            {
                Key = "dorduncu",
                Value = 104
            }; Pair<string, int> pair5 = new Pair<string, int>
            {
                Key = "besinci",
                Value = 105
            };
            Pair<string, int>.Add(pair4);
            Pair<string, int>.Add(pair5);
            Pair<string,int>.PrintInfo();
        }
    }
}
