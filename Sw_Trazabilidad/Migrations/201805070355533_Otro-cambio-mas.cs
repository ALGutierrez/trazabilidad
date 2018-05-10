namespace Sw_Trazabilidad.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Otrocambiomas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Entradas", "LoteEntrada", c => c.String(nullable: false, maxLength: 45));
            AddColumn("dbo.Salidas", "LoteSalida", c => c.String(nullable: false, maxLength: 45));
            DropColumn("dbo.Procesos", "Lote");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Procesos", "Lote", c => c.String(nullable: false, maxLength: 45));
            DropColumn("dbo.Salidas", "LoteSalida");
            DropColumn("dbo.Entradas", "LoteEntrada");
        }
    }
}
