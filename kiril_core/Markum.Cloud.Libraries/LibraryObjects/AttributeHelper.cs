using System.Collections.Generic;

namespace Markum.Cloud.Libraries.LibraryObjects
{
    public static class AttributeHelper
    {
        public static Dictionary<string, object> GetCustomAttributesWithValue<T>
            (this object obj, string propertyName)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            foreach (var item in obj.GetType().GetProperties())
            {
                foreach (var p in item.GetCustomAttributes(typeof(T), false))
                {
                    if (p.GetType().GetProperty(propertyName) == null)
                        continue;

                    var name = p.GetType().GetProperty(propertyName).GetValue(p);

                    object value = item.GetValue(obj);

                    dic.Add(name.ToString(), value);
                }
            }
            return dic;
        }
    }
}
