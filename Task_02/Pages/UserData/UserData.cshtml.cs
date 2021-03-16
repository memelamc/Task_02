using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Task_02.Models;

namespace Task_02.Pages.UserData
{
    public class UserDataModel : PageModel
    {
        [BindProperty]
        public User Users { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid == false)
            {
                return Page();
            }

            return RedirectToPage("/Index", new { Users.Name });
        }
    }
}
