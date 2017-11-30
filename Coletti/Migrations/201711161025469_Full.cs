namespace Coletti.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Full : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cpf = c.String(),
                        Nome = c.String(),
                        Login = c.String(),
                        Senha = c.String(),
                        PrioridadeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Prioridades", t => t.PrioridadeId, cascadeDelete: true)
                .Index(t => t.PrioridadeId);
            
            CreateTable(
                "dbo.Prioridades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Funcionarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Login = c.String(),
                        Senha = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Mensagems",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        ClienteId = c.Int(nullable: false),
                        DataEnvio = c.DateTime(nullable: false),
                        RemetenteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Orcamentoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Valor = c.Double(nullable: false),
                        DataEntregaSugerida = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pedidoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        StatusId = c.Int(nullable: false),
                        DataRealizado = c.DateTime(nullable: false),
                        DataEntregaDesejada = c.DateTime(nullable: false),
                        ClienteId = c.Int(nullable: false),
                        OrcamentoId = c.Int(nullable: false),
                        Imagem = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Remetentes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clientes", "PrioridadeId", "dbo.Prioridades");
            DropIndex("dbo.Clientes", new[] { "PrioridadeId" });
            DropTable("dbo.Status");
            DropTable("dbo.Remetentes");
            DropTable("dbo.Pedidoes");
            DropTable("dbo.Orcamentoes");
            DropTable("dbo.Mensagems");
            DropTable("dbo.Funcionarios");
            DropTable("dbo.Prioridades");
            DropTable("dbo.Clientes");
        }
    }
}
