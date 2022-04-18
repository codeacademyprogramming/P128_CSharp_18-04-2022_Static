using P128Static.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P128Static.Extensions
{
    //Extension Method Yalniz Static Class Daxilinde Yazila Bilir
    static class Extension
    {
        //1-ci parametre yazilir ve bir defe yazilir
        //thi keywordunnen hansi typa aiddise o qeyd olunur
        public static bool IsOdd(this int num)
        {
            //if (num % 2 == 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            //if (num % 2 == 0)
            //    return true;
            //return false;

            return num % 2 == 0;
        }

        public static bool ChekcStringLength(this string str)
        {
            if (str.Length > 16)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ChekcChar(this string str, char symbol)
        {
            return str.Contains(symbol);
        }

        public static bool ChekcChar(this string str, char symbol, char letter)
        {
            return str.Contains(symbol);
        }
    }
}
