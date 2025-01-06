using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Typing_Game.Pages
{
    public class SpaceGameModel : PageModel
    {
        private readonly ILogger<SpaceGameModel> _logger;

        public SpaceGameModel(ILogger<SpaceGameModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
