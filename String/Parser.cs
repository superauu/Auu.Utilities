using System;

namespace Auu.Utilities.String
{
    public static class Parser
    {
        public static string GetStringInBracket(string str, string start, string end)
        {
            try
            {
                var startPosition = str.IndexOf(start, StringComparison.Ordinal);
                var endPosition = str.IndexOf(end, StringComparison.Ordinal);
                if (startPosition < 0 || endPosition < 0 || startPosition > endPosition) return null;

                if (startPosition == endPosition)
                {
                    if (endPosition == str.Length - 1) return null;
                    var nextPosition = str.Substring(endPosition + 1).IndexOf(end, StringComparison.Ordinal);
                    if (nextPosition < 0) return null;
                    endPosition += nextPosition + 1;
                }

                return str.Substring(startPosition + 1, endPosition - startPosition - 1);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}