namespace bookkeeping2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class skilltreemodel : DbContext
    {
        public skilltreemodel()
            : base("name=skilltreemodel")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
        public virtual DbSet<AccountBook> AccountBook { get; set; }
    }
}
