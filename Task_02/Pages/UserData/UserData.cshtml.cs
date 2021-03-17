using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Task_02.FileManagerServices;
using Task_02.Models;

namespace Task_02.Pages.UserData
{
    public class UserDataModel : PageModel
    {
        public FileManagerService UserDataService;
        public IEnumerable<User> Users { get; private set; } // setting to private set to not allow anyone to change the data

        public UserDataModel( FileManagerService userDataService)
        {
            UserDataService = userDataService; // initialize userData service -- not null
        }

        public void OnGet()
        {
            Users = UserDataService.GetUsers();
        }
        
    }
}
