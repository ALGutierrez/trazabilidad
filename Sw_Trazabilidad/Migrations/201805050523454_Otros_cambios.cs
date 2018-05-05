namespace Sw_Trazabilidad.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Otros_cambios : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Datos_Recepcion", "Id_Proceso", "dbo.Procesos");
            DropForeignKey("dbo.Entradas", "Codigo_Salida", "dbo.Salidas");
            DropIndex("dbo.Datos_Recepcion", new[] { "Id_Proceso" });
            DropIndex("dbo.Entradas", new[] { "Codigo_Salida" });
            AddColumn("dbo.Procesos", "Id_DatosRecepcion", c => c.Int());
            AlterColumn("dbo.Entradas", "Codigo_Salida", c => c.Int());
            CreateIndex("dbo.Entradas", "Codigo_Salida");
            CreateIndex("dbo.Procesos", "Id_DatosRecepcion");
            AddForeignKey("dbo.Procesos", "Id_DatosRecepcion", "dbo.Datos_Recepcion", "Id_DatosRecepcion");
            AddForeignKey("dbo.Entradas", "Codigo_Salida", "dbo.Salidas", "Codigo_Salida");
            DropColumn("dbo.Datos_Recepcion", "Id_Proceso");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Datos_Recepcion", "Id_Proceso", c => c.Int(nullable: false));
            DropForeignKey("dbo.Entradas", "Codigo_Salida", "dbo.Salidas");
            DropForeignKey("dbo.Procesos", "Id_DatosRecepcion", "dbo.Datos_Recepcion");
            DropIndex("dbo.Procesos", new[] { "Id_DatosRecepcion" });
            DropIndex("dbo.Entradas", new[] { "Codigo_Salida" });
            AlterColumn("dbo.Entradas", "Codigo_Salida", c => c.Int(nullable: false));
            DropColumn("dbo.Procesos", "Id_DatosRecepcion");
            CreateIndex("dbo.Entradas", "Codigo_Salida");
            CreateIndex("dbo.Datos_Recepcion", "Id_Proceso");
            AddForeignKey("dbo.Entradas", "Codigo_Salida", "dbo.Salidas", "Codigo_Salida", cascadeDelete: true);
            AddForeignKey("dbo.Datos_Recepcion", "Id_Proceso", "dbo.Procesos", "Id_Proceso", cascadeDelete: true);
        }
    }
}
