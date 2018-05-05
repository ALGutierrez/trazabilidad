namespace Sw_Trazabilidad.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Otros_cambios_dos : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Materia_Prima", "Id_LineaProducto", "dbo.Linea_Producto");
            DropIndex("dbo.Materia_Prima", new[] { "Id_LineaProducto" });
            AlterColumn("dbo.Materia_Prima", "Descripcion_Gral", c => c.String(maxLength: 45));
            AlterColumn("dbo.Materia_Prima", "Id_LineaProducto", c => c.Int());
            CreateIndex("dbo.Materia_Prima", "Id_LineaProducto");
            AddForeignKey("dbo.Materia_Prima", "Id_LineaProducto", "dbo.Linea_Producto", "Id_LineaProducto");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Materia_Prima", "Id_LineaProducto", "dbo.Linea_Producto");
            DropIndex("dbo.Materia_Prima", new[] { "Id_LineaProducto" });
            AlterColumn("dbo.Materia_Prima", "Id_LineaProducto", c => c.Int(nullable: false));
            AlterColumn("dbo.Materia_Prima", "Descripcion_Gral", c => c.String(nullable: false, maxLength: 45));
            CreateIndex("dbo.Materia_Prima", "Id_LineaProducto");
            AddForeignKey("dbo.Materia_Prima", "Id_LineaProducto", "dbo.Linea_Producto", "Id_LineaProducto", cascadeDelete: true);
        }
    }
}
