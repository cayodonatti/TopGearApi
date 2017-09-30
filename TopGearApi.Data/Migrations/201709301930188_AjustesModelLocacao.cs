namespace TopGearApi.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjustesModelLocacao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locacaos", "Entrega_Real", c => c.DateTime());
            AlterColumn("dbo.Locacaos", "Entrega", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Locacaos", "Entrega", c => c.DateTime());
            DropColumn("dbo.Locacaos", "Entrega_Real");
        }
    }
}
