using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DongolOfLegends.UI.Utility
{
    public class VueParser : IVueParser
    {
        public Dictionary<string, object> ParseData<TModel>(TModel model)
        {
            System.Reflection.PropertyInfo[] props = model.GetType().GetProperties();
            Dictionary<string, object> result = new Dictionary<string, object>();

            foreach (var prop in props)
            {
                VueData attr = prop.GetCustomAttributes(typeof(VueData), true)?.FirstOrDefault()
                    as VueData;

                if (attr == null)
                {
                    continue;
                }

                result.Add(attr.Name, prop.GetValue(model));
            }

            return result;
        }
    }
}
