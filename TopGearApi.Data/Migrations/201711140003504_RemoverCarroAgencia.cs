namespace TopGearApi.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoverCarroAgencia : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Carroes", "AgenciaId", "dbo.Agencias");
            DropIndex("dbo.Carroes", new[] { "AgenciaId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Carroes", "AgenciaId");
            AddForeignKey("dbo.Carroes", "AgenciaId", "dbo.Agencias", "Id", cascadeDelete: true);
        }
    }
}
