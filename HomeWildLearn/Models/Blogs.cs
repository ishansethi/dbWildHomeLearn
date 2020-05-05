namespace HomeWildLearn.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Blogs : DbContext
    {
        public Blogs()
            : base("name=Blogs")
        {
        }

        public virtual DbSet<Blog> Blog { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
