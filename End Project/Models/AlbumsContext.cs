using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace End_Project.Models {
    public class AlbumsContext : DbContext {
        public DbSet<Albums> albums { get; set; }
    }
}