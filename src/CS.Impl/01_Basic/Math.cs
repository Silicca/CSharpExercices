﻿using System;
using System.Collections.Generic;

namespace CS.Impl._01_Basic
{
    public class Math
    {
        public int Sum(int a, int b)
        {
            return a+b;
        }

        public int Divide(int a, int b)
        {
            return a/b;
        }

        public int SumTable(IEnumerable<int> integersTable)
        {
            int sum = 0;
            foreach (var num in integersTable)
            {
                sum += num;
            }
            return sum;
        }
    }
}

