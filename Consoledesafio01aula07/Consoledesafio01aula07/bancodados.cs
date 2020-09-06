namespace Consoledesafio01aula07
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class bancodados : DbContext
    {
        public bancodados()
            : base("name=bancodados")
        {
        }

        public virtual DbSet<Usuario> usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .Property(e => e.NOME)
                .IsUnicode(false);
        }
    }
}
