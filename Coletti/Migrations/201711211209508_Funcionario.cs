namespace Coletti.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Funcionario : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Funcionarios", "DataNascimento", c => c.DateTime(nullable: false));
            AddColumn("dbo.Funcionarios", "Cpf", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Funcionarios", "Cpf");
            DropColumn("dbo.Funcionarios", "DataNascimento");
        }
    }
}
