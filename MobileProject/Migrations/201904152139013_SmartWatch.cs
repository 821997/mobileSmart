namespace MobileProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SmartWatch : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SmartWatches",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        color = c.String(),
                        price = c.Int(nullable: false),
                        model = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SmartWatches");
        }
    }
}
