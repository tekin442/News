using News_Model.AdminModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace News_Data.Entity
{
    public class NewsContext :DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Setting> Setting { get; set; }
        public DbSet<Template> Template { get; set; }

    }
}