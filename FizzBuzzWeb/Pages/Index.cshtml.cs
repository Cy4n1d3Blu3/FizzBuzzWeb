using FizzBuzzWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FizzBuzzWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public FizzBuzz FizzBuzz { get; set; }
        public string Name { get; set; }
        public string FB { get; set; } = "";
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnPost()
        {
            FB = "";
            if (FizzBuzz.Number % 3 == 0) FB += "Fizz";
            if (FizzBuzz.Number % 5 == 0) FB += "Buzz";
            if (FizzBuzz.Number % 3 != 0 && FizzBuzz.Number % 5 != 0) FB += "Number: " + FizzBuzz.Number.ToString() + " is not a FizzBuzz number.";
            return Page();
        }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(Name)) Name = "User";
        }
    }
}