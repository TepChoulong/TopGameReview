using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace TopGameReview.Pages.TopFreeGame_Pages.Survival
{
    public class FreeShootingGames_Page_1 : PageModel
    {
        private readonly ILogger<FreeShootingGames_Page_1> _logger;

        public FreeShootingGames_Page_1(ILogger<FreeShootingGames_Page_1> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}