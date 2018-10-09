using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace End_Project.Models {
    public class AlbumsDB : DbContext
    {
        public DbSet<Albums> albums { get; set; }
    }

    public class UsersDB : DbContext
    {
        public DbSet<Users> users { get; set; }
    }
}