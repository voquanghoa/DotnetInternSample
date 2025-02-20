﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Basic
{
    public class Exercise15
    {
        public int findDigits(int n)
        {
            if (n <= 1) return n;

            double digits = 0;
            for (int i = 2; i <= n; i++)
            {
                digits += Math.Log10(i);
            }

            return (int)digits + 1;

        }
    }
}
