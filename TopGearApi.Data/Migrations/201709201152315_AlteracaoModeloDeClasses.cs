namespace TopGearApi.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteracaoModeloDeClasses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ItemCarroes",
                c => new
                    {
                        Item_Id = c.Int(nullable: false),
                        Carro_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Item_Id, t.Carro_Id })
                .ForeignKey("dbo.Items", t => t.Item_Id, cascadeDelete: true)
                .ForeignKey("dbo.Carroes", t => t.Carro_Id, cascadeDelete: true)
                .Index(t => t.Item_Id)
                .Index(t => t.Carro_Id);
            
            DropColumn("dbo.Categorias", "Itens");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categorias", "Itens", c => c.String(nullable: false));
            DropForeignKey("dbo.ItemCarroes", "Carro_Id", "dbo.Carroes");
            DropForeignKey("dbo.ItemCarroes", "Item_Id", "dbo.Items");
            DropIndex("dbo.ItemCarroes", new[] { "Carro_Id" });
            DropIndex("dbo.ItemCarroes", new[] { "Item_Id" });
            DropTable("dbo.ItemCarroes");
            DropTable("dbo.Items");
        }
    }
}
