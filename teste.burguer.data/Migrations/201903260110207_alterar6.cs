namespace teste.burguer.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alterar6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemPedido",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdCardapio = c.Int(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cardapio", t => t.IdCardapio)
                .Index(t => t.IdCardapio);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemPedido", "IdCardapio", "dbo.Cardapio");
            DropIndex("dbo.ItemPedido", new[] { "IdCardapio" });
            DropTable("dbo.ItemPedido");
        }
    }
}
