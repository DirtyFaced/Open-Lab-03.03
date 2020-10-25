using System;

namespace Open_Lab_03._03
{
    public class Comparator
    {
        public bool CompareCharactersCount(string str1, string str2)
        {
            int jedna = str1.Length;
            int dva = str2.Length;
            bool chungus;
            if  (jedna == dva)
            { chungus = true; }
            else
            { chungus = false; };
            return chungus;
        }
    }
}
