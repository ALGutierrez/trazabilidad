namespace Sw_Trazabilidad.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Agregada_relacion_materiaprima_proveedor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Materia_PrimaEmpresa_Proveedor",
                c => new
                    {
                        Materia_Prima_IdMateria_Prima = c.Int(nullable: false),
                        Empresa_Proveedor_IdEmpresa_Proveedor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Materia_Prima_IdMateria_Prima, t.Empresa_Proveedor_IdEmpresa_Proveedor })
                .ForeignKey("dbo.Materia_Prima", t => t.Materia_Prima_IdMateria_Prima, cascadeDelete: true)
                .ForeignKey("dbo.Empresa_Proveedor", t => t.Empresa_Proveedor_IdEmpresa_Proveedor, cascadeDelete: true)
                .Index(t => t.Materia_Prima_IdMateria_Prima)
                .Index(t => t.Empresa_Proveedor_IdEmpresa_Proveedor);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Materia_PrimaEmpresa_Proveedor", "Empresa_Proveedor_IdEmpresa_Proveedor", "dbo.Empresa_Proveedor");
            DropForeignKey("dbo.Materia_PrimaEmpresa_Proveedor", "Materia_Prima_IdMateria_Prima", "dbo.Materia_Prima");
            DropIndex("dbo.Materia_PrimaEmpresa_Proveedor", new[] { "Empresa_Proveedor_IdEmpresa_Proveedor" });
            DropIndex("dbo.Materia_PrimaEmpresa_Proveedor", new[] { "Materia_Prima_IdMateria_Prima" });
            DropTable("dbo.Materia_PrimaEmpresa_Proveedor");
        }
    }
}
