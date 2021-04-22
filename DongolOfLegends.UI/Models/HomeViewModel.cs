using DongolOfLegends.API.Models.Models.MatchHistory;
using DongolOfLegends.UI.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DongolOfLegends.UI.Models
{
    public class HomeViewModel : BaseViewModel
    {
        [VueData("searchText")]
        public string searchText { get; set; }

        [VueData("searchPlaceholder")]
        public string SearchPlaceholder { get; set; } = "Search for Summoner...";

        [VueData("matchHistory")]
        public SummonerMatchesDetailed MatchHistory { get; set; } = new SummonerMatchesDetailed();

    }
}
