namespace Coletti.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClienteRazaoSocial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "RazaoSocial", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "RazaoSocial");
        }
    }
}
