namespace Coletti.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Orcamento : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Clientes", "PrioridadeId", "dbo.Prioridades");
            DropIndex("dbo.Clientes", new[] { "PrioridadeId" });
            AddColumn("dbo.Orcamentoes", "PrioridadeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Orcamentoes", "PrioridadeId");
            AddForeignKey("dbo.Orcamentoes", "PrioridadeId", "dbo.Prioridades", "Id", cascadeDelete: true);
            DropColumn("dbo.Clientes", "PrioridadeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clientes", "PrioridadeId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Orcamentoes", "PrioridadeId", "dbo.Prioridades");
            DropIndex("dbo.Orcamentoes", new[] { "PrioridadeId" });
            DropColumn("dbo.Orcamentoes", "PrioridadeId");
            CreateIndex("dbo.Clientes", "PrioridadeId");
            AddForeignKey("dbo.Clientes", "PrioridadeId", "dbo.Prioridades", "Id", cascadeDelete: true);
        }
    }
}
