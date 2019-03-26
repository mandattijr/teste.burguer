namespace teste.burguer.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alterar4 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Cardapio", new[] { "IdProduto" });
            DropIndex("dbo.Cardapio", new[] { "IdBebida" });
            DropIndex("dbo.Cardapio", new[] { "IdPrato" });
            AlterColumn("dbo.Cardapio", "IdProduto", c => c.Int());
            AlterColumn("dbo.Cardapio", "IdBebida", c => c.Int());
            AlterColumn("dbo.Cardapio", "IdPrato", c => c.Int());
            CreateIndex("dbo.Cardapio", "IdProduto");
            CreateIndex("dbo.Cardapio", "IdBebida");
            CreateIndex("dbo.Cardapio", "IdPrato");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Cardapio", new[] { "IdPrato" });
            DropIndex("dbo.Cardapio", new[] { "IdBebida" });
            DropIndex("dbo.Cardapio", new[] { "IdProduto" });
            AlterColumn("dbo.Cardapio", "IdPrato", c => c.Int(nullable: false));
            AlterColumn("dbo.Cardapio", "IdBebida", c => c.Int(nullable: false));
            AlterColumn("dbo.Cardapio", "IdProduto", c => c.Int(nullable: false));
            CreateIndex("dbo.Cardapio", "IdPrato");
            CreateIndex("dbo.Cardapio", "IdBebida");
            CreateIndex("dbo.Cardapio", "IdProduto");
        }
    }
}
