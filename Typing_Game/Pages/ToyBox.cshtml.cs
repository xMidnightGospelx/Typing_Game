using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Typing_Game.Pages
{
    public class ToyBoxModel : PageModel
    {
        private readonly ILogger<ToyBoxModel> _logger;

        public ToyBoxModel(ILogger<ToyBoxModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
