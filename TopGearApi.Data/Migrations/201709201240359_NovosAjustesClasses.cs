namespace TopGearApi.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NovosAjustesClasses : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Carroes", "Agencia_Id", "dbo.Agencias");
            DropForeignKey("dbo.Carroes", "Categoria_Id", "dbo.Categorias");
            DropForeignKey("dbo.Locacaos", "Cliente_Id", "dbo.Clientes");
            DropForeignKey("dbo.Locacaos", "Carro_Id", "dbo.Carroes");
            DropIndex("dbo.Carroes", new[] { "Agencia_Id" });
            DropIndex("dbo.Carroes", new[] { "Categoria_Id" });
            DropIndex("dbo.Locacaos", new[] { "Carro_Id" });
            DropIndex("dbo.Locacaos", new[] { "Cliente_Id" });
            RenameColumn(table: "dbo.Carroes", name: "Agencia_Id", newName: "AgenciaId");
            RenameColumn(table: "dbo.Carroes", name: "Categoria_Id", newName: "CategoriaId");
            RenameColumn(table: "dbo.Locacaos", name: "Cliente_Id", newName: "ClienteId");
            RenameColumn(table: "dbo.Locacaos", name: "Agencia_Entrega_Id", newName: "Agencia_EntregaId");
            RenameColumn(table: "dbo.Locacaos", name: "Agencia_Retirada_Id", newName: "Agencia_RetiradaId");
            RenameColumn(table: "dbo.Locacaos", name: "Carro_Id", newName: "CarroId");
            RenameIndex(table: "dbo.Locacaos", name: "IX_Agencia_Retirada_Id", newName: "IX_Agencia_RetiradaId");
            RenameIndex(table: "dbo.Locacaos", name: "IX_Agencia_Entrega_Id", newName: "IX_Agencia_EntregaId");
            AlterColumn("dbo.Carroes", "AgenciaId", c => c.Int(nullable: false));
            AlterColumn("dbo.Carroes", "CategoriaId", c => c.Int(nullable: false));
            AlterColumn("dbo.Locacaos", "CarroId", c => c.Int(nullable: false));
            AlterColumn("dbo.Locacaos", "ClienteId", c => c.Int(nullable: false));
            CreateIndex("dbo.Carroes", "AgenciaId");
            CreateIndex("dbo.Carroes", "CategoriaId");
            CreateIndex("dbo.Locacaos", "ClienteId");
            CreateIndex("dbo.Locacaos", "CarroId");
            AddForeignKey("dbo.Carroes", "AgenciaId", "dbo.Agencias", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Carroes", "CategoriaId", "dbo.Categorias", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Locacaos", "ClienteId", "dbo.Clientes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Locacaos", "CarroId", "dbo.Carroes", "Id", cascadeDelete: true);
            DropColumn("dbo.Carroes", "EmManutencao");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Carroes", "EmManutencao", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.Locacaos", "CarroId", "dbo.Carroes");
            DropForeignKey("dbo.Locacaos", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.Carroes", "CategoriaId", "dbo.Categorias");
            DropForeignKey("dbo.Carroes", "AgenciaId", "dbo.Agencias");
            DropIndex("dbo.Locacaos", new[] { "CarroId" });
            DropIndex("dbo.Locacaos", new[] { "ClienteId" });
            DropIndex("dbo.Carroes", new[] { "CategoriaId" });
            DropIndex("dbo.Carroes", new[] { "AgenciaId" });
            AlterColumn("dbo.Locacaos", "ClienteId", c => c.Int());
            AlterColumn("dbo.Locacaos", "CarroId", c => c.Int());
            AlterColumn("dbo.Carroes", "CategoriaId", c => c.Int());
            AlterColumn("dbo.Carroes", "AgenciaId", c => c.Int());
            RenameIndex(table: "dbo.Locacaos", name: "IX_Agencia_EntregaId", newName: "IX_Agencia_Entrega_Id");
            RenameIndex(table: "dbo.Locacaos", name: "IX_Agencia_RetiradaId", newName: "IX_Agencia_Retirada_Id");
            RenameColumn(table: "dbo.Locacaos", name: "CarroId", newName: "Carro_Id");
            RenameColumn(table: "dbo.Locacaos", name: "Agencia_RetiradaId", newName: "Agencia_Retirada_Id");
            RenameColumn(table: "dbo.Locacaos", name: "Agencia_EntregaId", newName: "Agencia_Entrega_Id");
            RenameColumn(table: "dbo.Locacaos", name: "ClienteId", newName: "Cliente_Id");
            RenameColumn(table: "dbo.Carroes", name: "CategoriaId", newName: "Categoria_Id");
            RenameColumn(table: "dbo.Carroes", name: "AgenciaId", newName: "Agencia_Id");
            CreateIndex("dbo.Locacaos", "Cliente_Id");
            CreateIndex("dbo.Locacaos", "Carro_Id");
            CreateIndex("dbo.Carroes", "Categoria_Id");
            CreateIndex("dbo.Carroes", "Agencia_Id");
            AddForeignKey("dbo.Locacaos", "Carro_Id", "dbo.Carroes", "Id");
            AddForeignKey("dbo.Locacaos", "Cliente_Id", "dbo.Clientes", "Id");
            AddForeignKey("dbo.Carroes", "Categoria_Id", "dbo.Categorias", "Id");
            AddForeignKey("dbo.Carroes", "Agencia_Id", "dbo.Agencias", "Id");
        }
    }
}
