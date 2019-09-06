using System.Text.RegularExpressions;

namespace StringExtensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Return substring of length maxLength.
        /// </summary>
        /// <param name="maxLength"></param>
        /// <returns>string</returns>
        public static string LimitLength(this string source, int maxLength)
        {
            if (source.Length <= maxLength)
                return source;
            return source.Substring(0, maxLength);
        }

        /// <summary>
        /// Return the input string without diacriticals.
        /// Diacritics are replaced by their unaccented equivalents.
        /// </summary>
        /// <returns>string</returns>
        public static string RemoveDiacritical(this string source) =>
            System.Text.Encoding.UTF8.GetString(System.Text.Encoding.GetEncoding("ISO-8859-7").GetBytes(source));

        /// <summary>
        /// Return string without non-Alphanumeric chars.
        /// Non-Alphanumeric chars are removed.
        /// </summary>
        /// <param name="keepBlank">bool, default set to false. If set to true, blank are kept exept if they are at the end of the chain.</param>
        /// <returns>string</returns>
        public static string RemoveNonAlphaNum(this string source, bool keepBlank = false) =>
            Regex.Replace(Regex.Replace(source, keepBlank ? "[^a-zA-Z\x20]" : "[^a-zA-Z]", ""), "\x20$", "");
    }
}
