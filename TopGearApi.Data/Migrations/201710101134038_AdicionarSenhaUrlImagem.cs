namespace TopGearApi.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionarSenhaUrlImagem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Carroes", "UrlImagem", c => c.String());
            AddColumn("dbo.Clientes", "Senha", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "Senha");
            DropColumn("dbo.Carroes", "UrlImagem");
        }
    }
}
