using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DongolOfLegends.UI.Client
{
    public interface IClient
    {
        T GetRequestForItem<T>(string requestUrl);
        T GetRequestForItem<T>(params string[] complexUrl);
        List<T> GetRequestForList<T>(string requestUrl);
        List<T> GetRequestForList<T>(params string[] complexUrl);
    }
}
