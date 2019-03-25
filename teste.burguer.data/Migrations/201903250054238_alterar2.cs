namespace teste.burguer.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alterar2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ItemPratoProdutoes", newName: "ItemPratoProduto");
            RenameTable(name: "dbo.Cardapios", newName: "Cardapio");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Cardapio", newName: "Cardapios");
            RenameTable(name: "dbo.ItemPratoProduto", newName: "ItemPratoProdutoes");
        }
    }
}
