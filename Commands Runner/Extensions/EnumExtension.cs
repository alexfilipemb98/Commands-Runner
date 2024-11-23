using Commands_Runner.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;

namespace Commands_Runner.Extensions
{
    public static class EnumExtension
    {
        public static List<CommandTypeInfoModel> ToList(this Type enumType)
        {
            if (!enumType.IsEnum)
                throw new ArgumentException("Provided type must be an enum.");

            List<CommandTypeInfoModel> enums = Enum.GetValues(enumType)
                .Cast<Enum>()
                .Select(e => new CommandTypeInfoModel
                {
                    Type = e.ToString(),
                    Description = e.GetDescription()
                })
                .ToList();

            return enums;
        }

        public static string GetDescription(this Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            DescriptionAttribute attribute = field.GetCustomAttribute<DescriptionAttribute>();
            return attribute?.Description ?? value.ToString();
        }

        public static TEnum GetEnumByName<TEnum>(string name, bool ignoreCase = false) where TEnum : struct, Enum
        {
            if (Enum.TryParse(name, ignoreCase, out TEnum result))
                return result;
            
            return default;
        }
    }
}
