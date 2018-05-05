namespace Sw_Trazabilidad.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Otros_cambios_cuatro : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Productos", "Id_LineaProducto", "dbo.Linea_Producto");
            DropIndex("dbo.Productos", new[] { "Id_LineaProducto" });
            AddColumn("dbo.Linea_Producto", "Id_Producto", c => c.Int(nullable: false));
            CreateIndex("dbo.Linea_Producto", "Id_Producto");
            AddForeignKey("dbo.Linea_Producto", "Id_Producto", "dbo.Productos", "Id_Producto", cascadeDelete: true);
            DropColumn("dbo.Productos", "Id_LineaProducto");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Productos", "Id_LineaProducto", c => c.Int(nullable: false));
            DropForeignKey("dbo.Linea_Producto", "Id_Producto", "dbo.Productos");
            DropIndex("dbo.Linea_Producto", new[] { "Id_Producto" });
            DropColumn("dbo.Linea_Producto", "Id_Producto");
            CreateIndex("dbo.Productos", "Id_LineaProducto");
            AddForeignKey("dbo.Productos", "Id_LineaProducto", "dbo.Linea_Producto", "Id_LineaProducto", cascadeDelete: true);
        }
    }
}
