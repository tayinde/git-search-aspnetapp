using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using gitsearch_aspnetapp.Models;

namespace gitsearch_aspnetapp.Controllers
{
    public class SearchController : Controller
    {
        private readonly ILogger<SearchController> Logger;

        public SearchController(ILogger<SearchController> logger)
        {
            Logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public async Task<IActionResult> Repos(string user, string avatar)
        {
            return View(await ReposViewModel.GetRepos(user, avatar));
        }
        public IActionResult Purpose()
        {
            return View();
        }
        public async Task<ActionResult> GetUser(string user)
        {
            return View(await GetUserViewModel.GetUserInfo(user));
        }
        public async Task<ActionResult> Followers(string user, string avatar)
        {
            return View(await FollowersViewModel.GetFollowers(user, avatar));
        }
        public async Task<ActionResult> Following(string user, string avatar)
        {
            return View(await FollowingViewModel.GetFollowers(user, avatar));
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
