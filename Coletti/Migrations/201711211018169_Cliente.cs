namespace Coletti.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cliente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Cnpj", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "Cnpj");
        }
    }
}
