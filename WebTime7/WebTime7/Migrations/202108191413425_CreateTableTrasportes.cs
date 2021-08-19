namespace WebTime7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableTrasportes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TrasportModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Description = c.String(),
                        valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TrasportModels");
        }
    }
}
