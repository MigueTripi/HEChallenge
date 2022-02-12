using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HE.Challenge
{
    public class NumberCalculator
    {

        public int[] SumValuesFromArraysReversingSecond(int[] arrayX, int[] arrayY)
        {
            if (arrayX == null && arrayY == null) return null;
            if (arrayX == null || arrayX.Length == 0 && arrayY != null) return arrayY;
            if (arrayY == null || arrayY.Length == 0) return arrayX;

            return SumArraysReversingSecond(arrayX, arrayY);
        }

        private int[] SumArraysReversingSecond(int[] arrayX, int[] arrayY)
        {
            //Identify which array is longest.
            var lengthResult = arrayX.Length >= arrayY.Length ? arrayX.Length : arrayY.Length;
            var result = new int[lengthResult];
            var ArrayYLastIndex = arrayY.Length - 1;

            //Based on arrayX I iterate and sum all the values in this array
            //with arrayY reversed logically.
            for (int i = 0; i < arrayX.Length; i++)
            {
                result[i] = arrayX[i];
                if (ArrayYLastIndex - i >= 0)
                {
                    result[i] += arrayY[ArrayYLastIndex - i];
                }
            }

            //I check if the result still contains values to add from the arrayY.
            //If so, I iterate only the remaining values of arrayY from the last index used of arrayX
            if (lengthResult == arrayY.Length)
            {
                for (int i = 0; i < arrayY.Length - arrayX.Length; i++)
                {
                    result[arrayX.Length + i] = arrayY[arrayX.Length - 1 - i];
                }
            }

            return result;
        }

    }
}
