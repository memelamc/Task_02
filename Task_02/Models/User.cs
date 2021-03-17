using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Task_02.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
        public string Gender { get; set; }
        public string IpAddress { get; set; }

        public override string ToString() => JsonSerializer.Serialize<User>(this);
    }
}
