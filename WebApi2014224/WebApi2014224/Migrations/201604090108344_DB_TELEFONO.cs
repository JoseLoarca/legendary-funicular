namespace WebApi2014224.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DB_TELEFONO : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Telefonoes",
                c => new
                    {
                        idTelefono = c.Int(nullable: false, identity: true),
                        modelo = c.String(),
                        marca = c.String(),
                        almacenamientoInterno = c.String(),
                        memoriaRam = c.String(),
                    })
                .PrimaryKey(t => t.idTelefono);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Telefonoes");
        }
    }
}
