namespace teste.burguer.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alterar1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Pratoes", newName: "Prato");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Prato", newName: "Pratoes");
        }
    }
}
