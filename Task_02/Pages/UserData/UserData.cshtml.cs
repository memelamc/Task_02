using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Task_02.FileManagerService;
using Task_02.Models;

namespace Task_02.Pages.UserData
{
    public class UserDataModel : PageModel
    {

        private readonly IFileManager _fileManager;

        public UserDataModel(IFileManager fileManager)
        {
            _fileManager = fileManager;
        }

        public JsonResult OnGet()
        {
            return new JsonResult(_fileManager.ReadAll());
        }
        
    }
}
