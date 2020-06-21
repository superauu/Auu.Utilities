using System;

namespace Auu.Utilities.String
{
    public static class Converter
    {
        public static int? ToInt(string str)
        {
            if (int.TryParse(str, out var result)) return result;

            return null;
        }

        public static float? ToFloat(string str)
        {
            if (float.TryParse(str, out var result)) return result;

            return null;
        }

        public static double? ToDouble(string str)
        {
            if (double.TryParse(str, out var result)) return result;

            return null;
        }

        public static decimal? ToDecimal(string str)
        {
            if (decimal.TryParse(str, out var result)) return result;

            return null;
        }

        public static DateTime? ToDateTime(string str)
        {
            if (DateTime.TryParse(str, out var result)) return result;

            return null;
        }
    }
}