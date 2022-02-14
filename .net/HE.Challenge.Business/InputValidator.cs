using System.Text.RegularExpressions;

namespace HE.Challenge.Business
{
    public static class InputValidator
    {
        public static bool TryParseArray(string? input, out int[]? array)
        {
            array = null;
            if (input == null) return false;

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
