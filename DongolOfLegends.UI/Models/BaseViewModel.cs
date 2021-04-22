using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DongolOfLegends.UI.Models
{
    public class BaseViewModel
    {
        public Dictionary<string, object> VueData { get; set; } = new Dictionary<string, object>();
    }
}
