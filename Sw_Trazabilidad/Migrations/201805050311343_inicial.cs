namespace Sw_Trazabilidad.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cosechas",
                c => new
                    {
                        Id_Cosecha = c.Int(nullable: false, identity: true),
                        Año = c.Int(nullable: false),
                        Descripcion = c.String(maxLength: 45),
                    })
                .PrimaryKey(t => t.Id_Cosecha);
            
            CreateTable(
                "dbo.Datos_Recepcion",
                c => new
                    {
                        Id_DatosRecepcion = c.Int(nullable: false, identity: true),
                        Planta = c.Int(nullable: false),
                        Id_Cosecha = c.Int(nullable: false),
                        Id_Gramaje = c.Int(nullable: false),
                        Id_Envase = c.Int(nullable: false),
                        Id_Proceso = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id_DatosRecepcion)
                .ForeignKey("dbo.Cosechas", t => t.Id_Cosecha, cascadeDelete: true)
                .ForeignKey("dbo.Envases", t => t.Id_Envase, cascadeDelete: true)
                .ForeignKey("dbo.Gramajes", t => t.Id_Gramaje, cascadeDelete: true)
                .ForeignKey("dbo.Procesoes", t => t.Id_Proceso, cascadeDelete: true)
                .Index(t => t.Id_Cosecha)
                .Index(t => t.Id_Gramaje)
                .Index(t => t.Id_Envase)
                .Index(t => t.Id_Proceso);
            
            CreateTable(
                "dbo.Envases",
                c => new
                    {
                        Id_Envase = c.Int(nullable: false, identity: true),
                        Nombre_Tipo = c.String(nullable: false, maxLength: 45),
                        Descripcion = c.String(maxLength: 45),
                    })
                .PrimaryKey(t => t.Id_Envase);
            
            CreateTable(
                "dbo.Gramajes",
                c => new
                    {
                        Id_Gramaje = c.Int(nullable: false, identity: true),
                        Peso = c.Int(nullable: false),
                        Descripcion = c.String(maxLength: 45),
                    })
                .PrimaryKey(t => t.Id_Gramaje);
            
            CreateTable(
                "dbo.Procesoes",
                c => new
                    {
                        Id_Proceso = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 45),
                        Es_Recepcion = c.Boolean(nullable: false),
                        Lote = c.String(nullable: false, maxLength: 45),
                        Fecha_Actividad = c.DateTime(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        Observaciones = c.String(nullable: false, maxLength: 45),
                        Codigo_Entrada = c.Int(nullable: false),
                        Codigo_Salida = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id_Proceso)
                .ForeignKey("dbo.Entradas", t => t.Codigo_Entrada, cascadeDelete: true)
                .ForeignKey("dbo.Salidas", t => t.Codigo_Salida, cascadeDelete: true)
                .Index(t => t.Codigo_Entrada)
                .Index(t => t.Codigo_Salida);
            
            CreateTable(
                "dbo.Entradas",
                c => new
                    {
                        Codigo_Entrada = c.Int(nullable: false, identity: true),
                        descripcion_entrada = c.String(maxLength: 45),
                        Codigo_Salida = c.Int(nullable: false),
                        IdMateria_Prima = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Codigo_Entrada)
                .ForeignKey("dbo.Materia_Prima", t => t.IdMateria_Prima, cascadeDelete: true)
                .ForeignKey("dbo.Salidas", t => t.Codigo_Salida, cascadeDelete: true)
                .Index(t => t.Codigo_Salida)
                .Index(t => t.IdMateria_Prima);
            
            CreateTable(
                "dbo.Materia_Prima",
                c => new
                    {
                        IdMateria_Prima = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 45),
                        Descripcion_Gral = c.String(nullable: false, maxLength: 45),
                        IdTipo_MateriaPrima = c.Int(nullable: false),
                        Id_LineaProducto = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdMateria_Prima)
                .ForeignKey("dbo.Linea_Producto", t => t.Id_LineaProducto, cascadeDelete: true)
                .ForeignKey("dbo.Tipo_MateriaPrima", t => t.IdTipo_MateriaPrima, cascadeDelete: true)
                .Index(t => t.IdTipo_MateriaPrima)
                .Index(t => t.Id_LineaProducto);
            
            CreateTable(
                "dbo.Linea_Producto",
                c => new
                    {
                        Id_LineaProducto = c.Int(nullable: false, identity: true),
                        Id_Producto = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id_LineaProducto)
                .ForeignKey("dbo.Productoes", t => t.Id_Producto, cascadeDelete: true)
                .Index(t => t.Id_Producto);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        Id_Producto = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 45),
                        Descripcion = c.String(maxLength: 45),
                    })
                .PrimaryKey(t => t.Id_Producto);
            
            CreateTable(
                "dbo.Tipo_MateriaPrima",
                c => new
                    {
                        IdTipo_MateriaPrima = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 45),
                        Descripcion = c.String(maxLength: 45),
                    })
                .PrimaryKey(t => t.IdTipo_MateriaPrima);
            
            CreateTable(
                "dbo.Salidas",
                c => new
                    {
                        Codigo_Salida = c.Int(nullable: false, identity: true),
                        Descripcion_salida = c.String(maxLength: 45),
                        Id_Producto = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Codigo_Salida)
                .ForeignKey("dbo.Productoes", t => t.Id_Producto, cascadeDelete: true)
                .Index(t => t.Id_Producto);
            
            CreateTable(
                "dbo.Empresa_Proveedor",
                c => new
                    {
                        IdEmpresa_Proveedor = c.Int(nullable: false, identity: true),
                        RazonSocial = c.String(nullable: false, maxLength: 45),
                        CUIT = c.Int(nullable: false),
                        Direccion = c.String(nullable: false, maxLength: 45),
                    })
                .PrimaryKey(t => t.IdEmpresa_Proveedor);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Datos_Recepcion", "Id_Proceso", "dbo.Procesoes");
            DropForeignKey("dbo.Procesoes", "Codigo_Salida", "dbo.Salidas");
            DropForeignKey("dbo.Procesoes", "Codigo_Entrada", "dbo.Entradas");
            DropForeignKey("dbo.Entradas", "Codigo_Salida", "dbo.Salidas");
            DropForeignKey("dbo.Salidas", "Id_Producto", "dbo.Productoes");
            DropForeignKey("dbo.Entradas", "IdMateria_Prima", "dbo.Materia_Prima");
            DropForeignKey("dbo.Materia_Prima", "IdTipo_MateriaPrima", "dbo.Tipo_MateriaPrima");
            DropForeignKey("dbo.Materia_Prima", "Id_LineaProducto", "dbo.Linea_Producto");
            DropForeignKey("dbo.Linea_Producto", "Id_Producto", "dbo.Productoes");
            DropForeignKey("dbo.Datos_Recepcion", "Id_Gramaje", "dbo.Gramajes");
            DropForeignKey("dbo.Datos_Recepcion", "Id_Envase", "dbo.Envases");
            DropForeignKey("dbo.Datos_Recepcion", "Id_Cosecha", "dbo.Cosechas");
            DropIndex("dbo.Salidas", new[] { "Id_Producto" });
            DropIndex("dbo.Linea_Producto", new[] { "Id_Producto" });
            DropIndex("dbo.Materia_Prima", new[] { "Id_LineaProducto" });
            DropIndex("dbo.Materia_Prima", new[] { "IdTipo_MateriaPrima" });
            DropIndex("dbo.Entradas", new[] { "IdMateria_Prima" });
            DropIndex("dbo.Entradas", new[] { "Codigo_Salida" });
            DropIndex("dbo.Procesoes", new[] { "Codigo_Salida" });
            DropIndex("dbo.Procesoes", new[] { "Codigo_Entrada" });
            DropIndex("dbo.Datos_Recepcion", new[] { "Id_Proceso" });
            DropIndex("dbo.Datos_Recepcion", new[] { "Id_Envase" });
            DropIndex("dbo.Datos_Recepcion", new[] { "Id_Gramaje" });
            DropIndex("dbo.Datos_Recepcion", new[] { "Id_Cosecha" });
            DropTable("dbo.Empresa_Proveedor");
            DropTable("dbo.Salidas");
            DropTable("dbo.Tipo_MateriaPrima");
            DropTable("dbo.Productoes");
            DropTable("dbo.Linea_Producto");
            DropTable("dbo.Materia_Prima");
            DropTable("dbo.Entradas");
            DropTable("dbo.Procesoes");
            DropTable("dbo.Gramajes");
            DropTable("dbo.Envases");
            DropTable("dbo.Datos_Recepcion");
            DropTable("dbo.Cosechas");
        }
    }
}
