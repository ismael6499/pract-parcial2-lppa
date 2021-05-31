namespace practica2parcialllpa1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPedidos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pedido",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Pochoclo", "Pedido_Id", c => c.Int());
            CreateIndex("dbo.Pochoclo", "Pedido_Id");
            AddForeignKey("dbo.Pochoclo", "Pedido_Id", "dbo.Pedido", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pochoclo", "Pedido_Id", "dbo.Pedido");
            DropIndex("dbo.Pochoclo", new[] { "Pedido_Id" });
            DropColumn("dbo.Pochoclo", "Pedido_Id");
            DropTable("dbo.Pedido");
        }
    }
}
