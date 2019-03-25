namespace teste.burguer.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class criar : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bebida",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        Descricao = c.String(nullable: false, maxLength: 255, unicode: false),
                        DataCriacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ItemBebida",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        Quantidade = c.Int(nullable: false),
                        IdProduto = c.Int(nullable: false),
                        IdBebida = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bebida", t => t.IdBebida)
                .ForeignKey("dbo.Produto", t => t.IdProduto)
                .Index(t => t.IdProduto)
                .Index(t => t.IdBebida);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        Quantidade = c.Int(nullable: false),
                        ValorUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IdTipoProduto = c.Int(nullable: false),
                        IdUnidadeMedida = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoProduto", t => t.IdTipoProduto)
                .ForeignKey("dbo.UnidadeMedida", t => t.IdUnidadeMedida)
                .Index(t => t.IdTipoProduto)
                .Index(t => t.IdUnidadeMedida);
            
            CreateTable(
                "dbo.TipoProduto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        DataCriacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UnidadeMedida",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        DataCriacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ItemPrato",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        IdPrato = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pratoes", t => t.IdPrato)
                .Index(t => t.IdPrato);
            
            CreateTable(
                "dbo.ItemPratoProdutoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantidade = c.Int(nullable: false),
                        IdProduto = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        ItemPrato_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Produto", t => t.IdProduto)
                .ForeignKey("dbo.ItemPrato", t => t.ItemPrato_Id)
                .Index(t => t.IdProduto)
                .Index(t => t.ItemPrato_Id);
            
            CreateTable(
                "dbo.Pratoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        Descricao = c.String(nullable: false, maxLength: 255, unicode: false),
                        DataCriacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cardapios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        Descricao = c.String(nullable: false, maxLength: 255, unicode: false),
                        IdProduto = c.Int(nullable: false),
                        IdBebida = c.Int(nullable: false),
                        IdPrato = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bebida", t => t.IdBebida)
                .ForeignKey("dbo.Pratoes", t => t.IdPrato)
                .ForeignKey("dbo.Produto", t => t.IdProduto)
                .Index(t => t.IdProduto)
                .Index(t => t.IdBebida)
                .Index(t => t.IdPrato);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cardapios", "IdProduto", "dbo.Produto");
            DropForeignKey("dbo.Cardapios", "IdPrato", "dbo.Pratoes");
            DropForeignKey("dbo.Cardapios", "IdBebida", "dbo.Bebida");
            DropForeignKey("dbo.ItemPrato", "IdPrato", "dbo.Pratoes");
            DropForeignKey("dbo.ItemPratoProdutoes", "ItemPrato_Id", "dbo.ItemPrato");
            DropForeignKey("dbo.ItemPratoProdutoes", "IdProduto", "dbo.Produto");
            DropForeignKey("dbo.ItemBebida", "IdProduto", "dbo.Produto");
            DropForeignKey("dbo.Produto", "IdUnidadeMedida", "dbo.UnidadeMedida");
            DropForeignKey("dbo.Produto", "IdTipoProduto", "dbo.TipoProduto");
            DropForeignKey("dbo.ItemBebida", "IdBebida", "dbo.Bebida");
            DropIndex("dbo.Cardapios", new[] { "IdPrato" });
            DropIndex("dbo.Cardapios", new[] { "IdBebida" });
            DropIndex("dbo.Cardapios", new[] { "IdProduto" });
            DropIndex("dbo.ItemPratoProdutoes", new[] { "ItemPrato_Id" });
            DropIndex("dbo.ItemPratoProdutoes", new[] { "IdProduto" });
            DropIndex("dbo.ItemPrato", new[] { "IdPrato" });
            DropIndex("dbo.Produto", new[] { "IdUnidadeMedida" });
            DropIndex("dbo.Produto", new[] { "IdTipoProduto" });
            DropIndex("dbo.ItemBebida", new[] { "IdBebida" });
            DropIndex("dbo.ItemBebida", new[] { "IdProduto" });
            DropTable("dbo.Cardapios");
            DropTable("dbo.Pratoes");
            DropTable("dbo.ItemPratoProdutoes");
            DropTable("dbo.ItemPrato");
            DropTable("dbo.UnidadeMedida");
            DropTable("dbo.TipoProduto");
            DropTable("dbo.Produto");
            DropTable("dbo.ItemBebida");
            DropTable("dbo.Bebida");
        }
    }
}
