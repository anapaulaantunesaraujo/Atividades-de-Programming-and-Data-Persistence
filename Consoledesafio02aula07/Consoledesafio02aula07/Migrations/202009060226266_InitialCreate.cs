namespace Consoledesafio02aula07.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Forecedores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeFantasia = c.String(),
                        CNPJ = c.String(),
                        Endereço = c.String(),
                        Cidade = c.String(),
                        CEP = c.String(),
                        Criacao = c.DateTime(nullable: false),
                        UltimaAlteracao = c.DateTime(nullable: false),
                        Exclusão = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Forecedores");
        }
    }
}
