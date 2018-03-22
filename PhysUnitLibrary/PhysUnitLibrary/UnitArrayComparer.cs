using System;
using System.Collections.Generic;
using System.Text;

namespace PhysUnitLibrary
{
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

        public int GetHashCode(int[] obj) // Taken directly from https://stackoverflow.com/questions/14663168/an-integer-array-as-a-key-for-dictionary 
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
