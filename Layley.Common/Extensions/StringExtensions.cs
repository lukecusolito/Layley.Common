using Newtonsoft.Json;
using System;
using System.Linq;

namespace Layley.Common.Extensions
{
    public static class StringExtensions
    {

        /// <summary>
        /// Format the date based on the configuration provided
        /// </summary>
        /// <param name="dateValue">Data value in string.</param>
        /// <param name="dateFormat">Date format. Example: dd/MM/yyyy</param>
        /// <returns>Formatted date value in string.</returns>
        public static string FormatDate(this string dateValue, string dateFormat)
        {
            string dateFormated = string.Empty;
            if (!string.IsNullOrEmpty(dateValue))
            {
                dateFormated = Convert.ToDateTime(dateValue).ToString(dateFormat);
            }

            return dateFormated;
        }

        /// <summary>
        /// Deserializes a json string to an object
        /// </summary>
        /// <typeparam name="T">Object type for deserialization</typeparam>
        /// <param name="jsonString">Json string to be deserialized</param>
        /// <returns></returns>
        public static T DeSerializeJson<T>(this string jsonString)
        {
            if (!string.IsNullOrEmpty(jsonString))
            {
                return JsonConvert.DeserializeObject<T>(jsonString);
            }
            return default(T);
        }

        /// <summary>
        /// Determins if string contains numbers or special characters.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool HasNumbersOrSpecialCharacters(this string value) =>
            value.Any(ch => !Char.IsLetter(ch));

        /// <summary>
        /// Determins if string contains special characters.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool HasSpecialCharacters(this string value) =>
            value.Any(ch => !Char.IsLetterOrDigit(ch));
    }
}
