namespace Layley.Common.Extensions
{
    public static class JObjectExtensions
    {
        /// <summary>
        /// Gets the value of a specific JToken and tries to parse its value to an object of Type T
        /// </summary>
        /// <typeparam name="T">The Object type</typeparam>
        /// <param name="key">The JToken property key</param>
        /// <param name="defaultValue">A default return value (Optional: will return the default for the object type)</param>
        /// <returns>The value for the specific JToken</returns>
        //public static T GetJTokenValue<T>(this JToken jToken, string key, T defaultValue = default(T))
        //{
        //    if (jToken == null || jToken[key] == null)
        //        return defaultValue;

        //    try { return jToken[key].ToObject<T>(); }
        //    catch { return defaultValue; }
        //}

        /// <summary>
        /// Gets a Date Value from a JToken with a specific date format
        /// </summary>
        /// <param name="key">The JToken property key for the date</param>
        /// <param name="format">The date format required</param>
        /// <param name="defaultValue">A default return value (Optional: will return the default for DateTime)</param>
        /// <returns></returns>
        //public static DateTime? GetJTokenDate(this JToken jToken, string key, string format = "yyyy-MM-dd", DateTime? defaultValue = default(DateTime?))
        //{
        //    if (jToken == null || jToken[key] == null)
        //        return defaultValue;

        //    var jsonSerializer = new JsonSerializer();
        //    jsonSerializer.Converters.Add(new IsoDateTimeConverter() { DateTimeFormat = format });

        //    try { return jToken[key].ToObject<DateTime?>(jsonSerializer); }
        //    catch { return defaultValue; }
        //}

        //public static T GetValue<T>(this JToken jToken, T defaultValue = default(T))
        //{
        //    if (jToken == null)
        //        return defaultValue;

        //    try { return jToken.ToObject<T>(); }
        //    catch { return defaultValue; }
        //}

        //public static bool IsNullOrEmpty(this JToken token)
        //{
        //    return (token == null) ||
        //           (token.Type == JTokenType.Array && !token.HasValues) ||
        //           (token.Type == JTokenType.Object && !token.HasValues) ||
        //           (token.Type == JTokenType.String && token.ToString() == string.Empty) ||
        //           (token.Type == JTokenType.Null);
        //}
    }
}
