using System;
using System.ComponentModel;
using System.Linq;
using Layley.Common.Attributes;

namespace Layley.Common.Extensions
{
    public static class EnumExtensions
    {
        /// <summary>
        /// Gets the description value if one exists otherwise returns the property name.
        /// </summary>
        /// <param name="enumeration"></param>
        /// <returns name="description">The description attribute value</returns>
        public static string GetDescription(this Enum enumeration)
        {
            var descriptionAttribute = GetEnumCustomAttribute<DescriptionAttribute>(enumeration);
            
            return descriptionAttribute != null ? descriptionAttribute.Description : enumeration.ToString();
        }

        /// <summary>
        /// Gets the code attribute value if one exists otherwise returns the property name.
        /// </summary>
        /// <param name="enumeration"></param>
        /// <returns name="code">The code attribute value.</returns>
        public static string GetCode(this Enum enumeration)
        {
            var codeAttribute = GetEnumCustomAttribute<CodeAttribute>(enumeration);
            
            return codeAttribute != null ? codeAttribute.Code : enumeration.ToString();
        }
        
        #region Helper Methods
        private static T GetEnumCustomAttribute<T>(Enum value)
            where T : Attribute
        {
            //  Get the enum type.
            Type enumType = value.GetType();

            //  Get the custom attribute.
            var customAttribute = enumType.GetField(value.ToString())
                .GetCustomAttributes(typeof(T), false)
                .FirstOrDefault() as T;

            return customAttribute;
        }
        #endregion
    }
}
