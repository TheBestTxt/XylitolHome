using System;
using System.Collections.Generic;
using System.Text;

namespace XylitolHome.Domain.Dto
{
    public class AddUser
    {
        public string Account { get; set; }
        public string Password { get; set; }
        public string NickName { get; set; }
        public string Mobile { get; set; }
    }
}
