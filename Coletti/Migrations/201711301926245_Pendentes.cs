namespace Coletti.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Pendentes : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.VitorHugoes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.VitorHugoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Cpf = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
