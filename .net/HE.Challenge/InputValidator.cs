using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HE.Challenge
{
    internal static class InputValidator
    {
        internal static bool TryParseArray(string input, out int[] array)
        {
            array = null;
            var splitedArray = Regex.Split(input, ",");
            var result = !splitedArray.Any(s => !int.TryParse(s, out int i));
            if (result)
            {
                array = Array.ConvertAll(splitedArray, s => int.Parse(s));
            }

            return result;
        }
    }
}
