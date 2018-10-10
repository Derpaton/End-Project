using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace End_Project.Models {

    public partial class AlbumsContext : DbContext { 
        public AlbumsContext()
        : base("name=AlbumsContext") { }

        public virtual DbSet<Users> users { get; set; }
        public virtual DbSet<Albums> albums { get; set; }
        
    }
}
