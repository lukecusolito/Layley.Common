using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Layley.Common.Enumerations;

namespace Layley.Common.Extensions
{
    public static class ObjectExtensions
    {
        /// <summary>
        /// Serializes object to json using the default serializer
        /// </summary>
        /// <param name="value">Object to be serialized</param>
        /// <returns></returns>
        public static string SerializeToJson(this object value) =>
            value != null 
                ? SerializeToJsonUsingNewtonsoftSerializer(value) 
                : string.Empty;

        /// <summary>
        /// Serializes object to json using a specified json serializer
        /// </summary>
        /// <param name="value">Object to be serialized</param>
        /// <param name="jsonSerializer">Serializer to be used in serialization</param>
        /// <returns></returns>
        public static string SerializeToJson(this object value, JsonSerializers jsonSerializer)
        {
            string serializedValue = string.Empty;

            if (value != null)
            {
                if (jsonSerializer == JsonSerializers.NewtonsoftSerializer)
                {
                    serializedValue = SerializeToJsonUsingNewtonsoftSerializer(value);
                }
            }

            return serializedValue;
        }

        #region Helper Methods
        private static string SerializeToJsonUsingNewtonsoftSerializer(object value) =>
            JsonConvert.SerializeObject(value);
        #endregion
    }
}
