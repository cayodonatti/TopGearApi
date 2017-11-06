namespace TopGearApi.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CancelamentoLocacao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locacaos", "Cancelada", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Locacaos", "Cancelada");
        }
    }
}
