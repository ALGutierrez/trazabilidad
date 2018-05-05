namespace Sw_Trazabilidad.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Otros_cambios_tres : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Linea_Producto", "Id_Producto", "dbo.Productos");
            DropForeignKey("dbo.Materia_Prima", "Id_LineaProducto", "dbo.Linea_Producto");
            DropIndex("dbo.Materia_Prima", new[] { "Id_LineaProducto" });
            DropIndex("dbo.Linea_Producto", new[] { "Id_Producto" });
            AddColumn("dbo.Linea_Producto", "IdMateria_Prima", c => c.Int(nullable: false));
            AddColumn("dbo.Productos", "Id_LineaProducto", c => c.Int(nullable: false));
            CreateIndex("dbo.Productos", "Id_LineaProducto");
            CreateIndex("dbo.Linea_Producto", "IdMateria_Prima");
            AddForeignKey("dbo.Linea_Producto", "IdMateria_Prima", "dbo.Materia_Prima", "IdMateria_Prima", cascadeDelete: true);
            AddForeignKey("dbo.Productos", "Id_LineaProducto", "dbo.Linea_Producto", "Id_LineaProducto", cascadeDelete: true);
            DropColumn("dbo.Materia_Prima", "Id_LineaProducto");
            DropColumn("dbo.Linea_Producto", "Id_Producto");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Linea_Producto", "Id_Producto", c => c.Int(nullable: false));
            AddColumn("dbo.Materia_Prima", "Id_LineaProducto", c => c.Int());
            DropForeignKey("dbo.Productos", "Id_LineaProducto", "dbo.Linea_Producto");
            DropForeignKey("dbo.Linea_Producto", "IdMateria_Prima", "dbo.Materia_Prima");
            DropIndex("dbo.Linea_Producto", new[] { "IdMateria_Prima" });
            DropIndex("dbo.Productos", new[] { "Id_LineaProducto" });
            DropColumn("dbo.Productos", "Id_LineaProducto");
            DropColumn("dbo.Linea_Producto", "IdMateria_Prima");
            CreateIndex("dbo.Linea_Producto", "Id_Producto");
            CreateIndex("dbo.Materia_Prima", "Id_LineaProducto");
            AddForeignKey("dbo.Materia_Prima", "Id_LineaProducto", "dbo.Linea_Producto", "Id_LineaProducto");
            AddForeignKey("dbo.Linea_Producto", "Id_Producto", "dbo.Productos", "Id_Producto", cascadeDelete: true);
        }
    }
}
