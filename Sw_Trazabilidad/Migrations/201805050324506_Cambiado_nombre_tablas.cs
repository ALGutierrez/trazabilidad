namespace Sw_Trazabilidad.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cambiado_nombre_tablas : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Procesoes", newName: "Procesos");
            RenameTable(name: "dbo.Productoes", newName: "Productos");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Productos", newName: "Productoes");
            RenameTable(name: "dbo.Procesos", newName: "Procesoes");
        }
    }
}
