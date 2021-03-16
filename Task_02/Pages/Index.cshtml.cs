using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_02.Pages
{
    public class IndexSurname : PageModel
    {
        private readonly ILogger<IndexSurname> _logger;

        public IndexSurname(ILogger<IndexSurname> logger)
        {
            _logger = logger;
        }

        [BindProperty (SupportsGet = true)]
        public string Name { get; set; }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                Name = "There";
            }
        }
    }
}
