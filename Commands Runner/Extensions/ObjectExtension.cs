using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Commands_Runner.Extensions
{
    public static class ObjectExtensions
    {

        public static T Clone<T>(this T source) where T : new()
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            T clone = new T();
            foreach (PropertyInfo property in source.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                if (property.CanRead && property.CanWrite)
                {
                    property.SetValue(clone, property.GetValue(source));
                }
            }

            return clone;
        }
    }
}
