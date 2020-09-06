using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Common;

namespace Consoledesafio01aula07
{
    public class context : DbContext
    {
        public DbSet<Usuario> Usuários { get; set; }

        public context()
        : base("Data Source=LAPTOP-MHSCGJ3A\\TESTEAULA;Initial Catalog=Usuario;Persist Security Info=True;User ID=sa;Password=123;Pooling=False") {
            Database.SetInitializer<context>(new CreateDatabaseIfNotExists<context>());
        }



        protected override void OnModelCreating(DbModelBuilder modelBiulder)
        {
            modelBiulder.Entity<Usuario>().ToTable("Usuario");
            base.OnModelCreating(modelBiulder);
        }
    }
}
//Consoledesafio01aula07.Properties.Settings.Consoledesafio01aula07String
//Data Source=LAPTOP-MHSCGJ3A\\TESTEAULA;Initial Catalog=Usuario;Persist Security Info=True;User ID=sa;Password=123;Pooling=False