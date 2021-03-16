using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_02.Models;

namespace Task_02.FileManagerService
{
    public class FileManager:IFileManager
    {
        public List<User> ReadAll()
        {
            List<User> Users = new List<User>
            {
                new User{Id = 1, Name="Mc1",Surname="Memela1",EmailAddress="memelamc@gmail.com",Gender="M",IpAddress="127.0.0.1"},
                new User{Id = 2, Name="Mc2",Surname="Memela2",EmailAddress="memelamc@gmail.com",Gender="F",IpAddress="127.0.0.1"},
                new User{Id = 3, Name="Mc3",Surname="Memela3",EmailAddress="memelamc@gmail.com",Gender="M",IpAddress="127.0.0.1"},
                new User{Id = 4, Name="Mc4",Surname="Memela4",EmailAddress="memelamc@gmail.com",Gender="M",IpAddress="127.0.0.1"},
                new User{Id = 5, Name="Mc5",Surname="Memela5",EmailAddress="memelamc@gmail.com",Gender="F",IpAddress="127.0.0.1"},
            };
            return Users;
        }
    }
}
