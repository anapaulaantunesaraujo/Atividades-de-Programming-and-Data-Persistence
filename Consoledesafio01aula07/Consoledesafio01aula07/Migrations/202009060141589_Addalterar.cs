namespace Consoledesafio01aula07.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addalterar : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuario", "APELIDO", c => c.String());
            AddColumn("dbo.Usuario", "DATANASCIMENTO", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuario", "DATANASCIMENTO");
            DropColumn("dbo.Usuario", "APELIDO");
        }
    }
}
