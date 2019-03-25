namespace teste.burguer.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alterar : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UnidadeMedida", "Sigla", c => c.String(nullable: false, maxLength: 2, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UnidadeMedida", "Sigla");
        }
    }
}
