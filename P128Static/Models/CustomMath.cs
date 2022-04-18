using System;
using System.Collections.Generic;
using System.Text;

namespace P128Static.Models
{
    //Static Keywordune Sahib Olan Klassdan Instance (Object) Almag Olmur
    //Static Keywordune Sahib Olan Klass-in Daxil Her Sey Static
    //Static Keywordune Sahib Olan Klass Miras Alib Vere Bilmir
    static class CustomMath
    {

        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static double Sum(double a, double b)
        {
            return a + b;
        }
    }
}
