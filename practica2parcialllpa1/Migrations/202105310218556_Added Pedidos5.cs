namespace practica2parcialllpa1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPedidos5 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Pochoclo", new[] { "Pedido_Id" });
            CreateIndex("dbo.Pochoclo", "pedido_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Pochoclo", new[] { "pedido_Id" });
            CreateIndex("dbo.Pochoclo", "Pedido_Id");
        }
    }
}
