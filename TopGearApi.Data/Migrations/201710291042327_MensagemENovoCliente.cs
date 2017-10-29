namespace TopGearApi.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MensagemENovoCliente : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mensagems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Texto = c.String(),
                        Origem = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Clientes", "Nascimento", c => c.DateTime(nullable: false));
            DropColumn("dbo.Clientes", "Telefone");
            DropColumn("dbo.Clientes", "Endereco");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clientes", "Endereco", c => c.String());
            AddColumn("dbo.Clientes", "Telefone", c => c.String());
            DropColumn("dbo.Clientes", "Nascimento");
            DropTable("dbo.Mensagems");
        }
    }
}
