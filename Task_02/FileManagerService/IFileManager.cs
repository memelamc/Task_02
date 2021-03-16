using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_02.Models;

namespace Task_02.FileManagerService
{
    public interface IFileManager
    {
        List<User> ReadAll();

    }
}
