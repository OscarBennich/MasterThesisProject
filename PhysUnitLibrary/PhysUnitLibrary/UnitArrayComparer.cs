using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary
{   
    /// <summary>
    /// Used to compare if two dimension arrays are equal
    /// </summary>
    public class UnitArrayComparer : IEqualityComparer<int[]>
    {
        public bool Equals(int[] x, int[] y)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] != y[i]) 
                {
                    return false;
                }
            }

            return true;
        }

        // This hash function is taken from https://stackoverflow.com/questions/14663168/an-integer-array-as-a-key-for-dictionary 
        public int GetHashCode(int[] obj) 
        {
            int result = 17;
            for (int i = 0; i < obj.Length; i++)
            {
                unchecked
                {
                    result = result * 23 + obj[i];
                }
            }

            return result;
        }
    }
}
