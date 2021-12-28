namespace PlcFxUa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        nodeId = c.String(),
                        displayName = c.String(),
                        dataType = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Measurements",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        time = c.DateTime(nullable: false),
                        value = c.String(),
                        monitoredId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Items", t => t.monitoredId, cascadeDelete: true)
                .Index(t => t.monitoredId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Measurements", "monitoredId", "dbo.Items");
            DropIndex("dbo.Measurements", new[] { "monitoredId" });
            DropTable("dbo.Measurements");
            DropTable("dbo.Items");
        }
    }
}
