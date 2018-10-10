namespace End_Project.Views.Home {
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext {
        public Model1()
            : base("name=Model1") {
        }

        public virtual DbSet<AlbumList> AlbumList { get; set; }
        public virtual DbSet<Albums> Albums { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
        }
    }
}
