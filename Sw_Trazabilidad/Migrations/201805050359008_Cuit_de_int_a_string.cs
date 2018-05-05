namespace Sw_Trazabilidad.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cuit_de_int_a_string : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Empresa_Proveedor", "CUIT", c => c.String(nullable: false, maxLength: 45));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Empresa_Proveedor", "CUIT", c => c.Int(nullable: false));
        }
    }
}
