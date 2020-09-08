using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoledesafio02aula07
{
    public class context : DbContext
    {
        public DbSet<FOrnecedoresDAL> Fornecedores { get; set; }

        public context()
        : base("Data Source=LAPTOP-MHSCGJ3A\\TESTEAULA;Initial Catalog=Usuario;Persist Security Info=True;User ID=sa;Password=123;Pooling=False")
        {
            Database.SetInitializer<context>(new CreateDatabaseIfNotExists<context>());
            Database.Initialize(true);
            Database.CreateIfNotExists();
        }
               
        protected override void OnModelCreating(DbModelBuilder modelBiulder)
        {
            modelBiulder.Entity<FOrnecedoresDAL>().ToTable("Forecedores");
            base.OnModelCreating(modelBiulder);
        }
    }
}