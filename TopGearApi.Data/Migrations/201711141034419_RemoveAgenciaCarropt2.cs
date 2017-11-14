namespace TopGearApi.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveAgenciaCarropt2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Carroes", "AgenciaId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Carroes", "AgenciaId", c => c.Int(nullable: false));
        }
    }
}
