namespace TopGearApi.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SenhaObrigatoria : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "Senha", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "Senha", c => c.String());
        }
    }
}
