using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace News_Model.AdminModel
{
    public class User 
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
    }
}