﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solutions
{
    public class TimeConversion
    {
        //https://www.hackerrank.com/challenges/time-conversion/problem

        internal void TakeInput()
        {
            string s = Console.ReadLine();

            string result = timeConversion(s);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private string timeConversion(string s)
        {
            DateTime d = DateTime.Parse(s);
            return d.ToString("HH:mm:ss");
        }
    }
}
