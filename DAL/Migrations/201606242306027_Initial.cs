using System.Data.Entity.Migrations;

namespace DAL.Migrations
{
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BlogAudit",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        EntityId = c.Int(nullable: false),
                        ChangedBy = c.String(),
                        ChangeDate = c.DateTime(nullable: false),
                        Action = c.String(),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Blog", t => t.EntityId, cascadeDelete: true)
                .Index(t => t.EntityId);
            
            CreateTable(
                "dbo.Blog",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BlogAudit", "EntityId", "dbo.Blog");
            DropIndex("dbo.BlogAudit", new[] { "EntityId" });
            DropTable("dbo.Blog");
            DropTable("dbo.BlogAudit");
        }
    }
}
