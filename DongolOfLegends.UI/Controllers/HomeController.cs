using DongolOfLegends.API.Models.Models.MatchHistory;
using DongolOfLegends.UI.Client;
using DongolOfLegends.UI.Models;
using DongolOfLegends.UI.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace DongolOfLegends.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IVueParser _parser;
        private readonly IClient _client;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration, IVueParser parser, IClient client)
        {
            _logger = logger;
            _parser = parser;
            _client = client;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            HomeViewModel viewModel = new HomeViewModel();
            viewModel.VueData = _parser.ParseData(viewModel);

            return View(viewModel);
        }

        [Route("api/Home/Player/{playerName}")]
        public IActionResult Player(string playerName)
        {
            SummonerMatchesDetailed matches = _client.GetRequestForItem<SummonerMatchesDetailed>(_configuration["Global:API_URL:DongolOfLegends.API"], $"/Search/MatchHistory/{playerName.Replace(" ", "")}");
            matches.PlayerName = playerName;
            return Ok(matches);
        }
    }
}
