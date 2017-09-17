namespace TopGearApi.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agencias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rua = c.String(nullable: false),
                        Numero = c.Int(nullable: false),
                        Bairro = c.String(nullable: false),
                        Cidade = c.String(nullable: false),
                        Estado = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Carroes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Modelo = c.String(nullable: false),
                        Marca = c.String(nullable: false),
                        Placa = c.String(nullable: false, maxLength: 7),
                        Ano = c.Int(nullable: false),
                        EmManutencao = c.Boolean(nullable: false),
                        Agencia_Id = c.Int(),
                        Categoria_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Agencias", t => t.Agencia_Id)
                .ForeignKey("dbo.Categorias", t => t.Categoria_Id)
                .Index(t => t.Placa, unique: true)
                .Index(t => t.Agencia_Id)
                .Index(t => t.Categoria_Id);
            
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Preco = c.Double(nullable: false),
                        Descricao = c.String(nullable: false),
                        Itens = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Telefone = c.String(),
                        Endereco = c.String(),
                        CPF = c.String(nullable: false, maxLength: 11),
                        Cartao = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.CPF, unique: true);
            
            CreateTable(
                "dbo.Locacaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Retirada = c.DateTime(nullable: false),
                        Entrega = c.DateTime(),
                        Id_Cliente = c.Int(nullable: false),
                        Id_Carro = c.Int(nullable: false),
                        Agencia_Entrega_Id = c.Int(),
                        Agencia_Retirada_Id = c.Int(),
                        Carro_Id = c.Int(),
                        Cliente_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Agencias", t => t.Agencia_Entrega_Id)
                .ForeignKey("dbo.Agencias", t => t.Agencia_Retirada_Id)
                .ForeignKey("dbo.Carroes", t => t.Carro_Id)
                .ForeignKey("dbo.Clientes", t => t.Cliente_Id)
                .Index(t => t.Agencia_Entrega_Id)
                .Index(t => t.Agencia_Retirada_Id)
                .Index(t => t.Carro_Id)
                .Index(t => t.Cliente_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Locacaos", "Cliente_Id", "dbo.Clientes");
            DropForeignKey("dbo.Locacaos", "Carro_Id", "dbo.Carroes");
            DropForeignKey("dbo.Locacaos", "Agencia_Retirada_Id", "dbo.Agencias");
            DropForeignKey("dbo.Locacaos", "Agencia_Entrega_Id", "dbo.Agencias");
            DropForeignKey("dbo.Carroes", "Categoria_Id", "dbo.Categorias");
            DropForeignKey("dbo.Carroes", "Agencia_Id", "dbo.Agencias");
            DropIndex("dbo.Locacaos", new[] { "Cliente_Id" });
            DropIndex("dbo.Locacaos", new[] { "Carro_Id" });
            DropIndex("dbo.Locacaos", new[] { "Agencia_Retirada_Id" });
            DropIndex("dbo.Locacaos", new[] { "Agencia_Entrega_Id" });
            DropIndex("dbo.Clientes", new[] { "CPF" });
            DropIndex("dbo.Carroes", new[] { "Categoria_Id" });
            DropIndex("dbo.Carroes", new[] { "Agencia_Id" });
            DropIndex("dbo.Carroes", new[] { "Placa" });
            DropTable("dbo.Locacaos");
            DropTable("dbo.Clientes");
            DropTable("dbo.Categorias");
            DropTable("dbo.Carroes");
            DropTable("dbo.Agencias");
        }
    }
}
