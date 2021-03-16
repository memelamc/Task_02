using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_02.Pages
{
    public class PrivacySurname : PageModel
    {
        private readonly ILogger<PrivacySurname> _logger;

        public PrivacySurname(ILogger<PrivacySurname> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
