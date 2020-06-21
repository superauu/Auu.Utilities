using System;

namespace Auu.Utilities.String
{
    public static class Extension
    {
        public static string GetStringInBracket(this string str, string start, string end)
        {
            return Parser.GetStringInBracket(str, start, end);
        }

        public static bool IsEmailAddressValid(this string email)
        {
            return Validator.IsEmailAddressValid(email);
        }

        public static int? ToInt(this string str)
        {
            return Converter.ToInt(str);
        }

        public static float? ToFloat(this string str)
        {
            return Converter.ToFloat(str);
        }

        public static double? ToDouble(this string str)
        {
            return Converter.ToDouble(str);
        }

        public static decimal? ToDecimal(this string str)
        {
            return Converter.ToDecimal(str);
        }

        public static DateTime? ToDateTime(this string str)
        {
            return Converter.ToDateTime(str);
        }
    }
}