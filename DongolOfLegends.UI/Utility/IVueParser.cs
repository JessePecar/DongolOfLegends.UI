using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DongolOfLegends.UI.Utility
{
    public interface IVueParser
    {
        Dictionary<string, object> ParseData<TModel>(TModel model);
    }
}
