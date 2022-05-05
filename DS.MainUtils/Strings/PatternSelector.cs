﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.MainUtils.Strings
{
    internal static class PatternSelector
    {
        public static string Select(RegexPatterns regexPatterns)
        {
            switch (regexPatterns)
            {
                case RegexPatterns.NoSpecialChar:
                   return @"^[A-Z0-9]*$";
                case RegexPatterns.Number:
                    return @"^[,0-9]*$";
                default:
                    break;
            }

            return "";
        }
    }
}