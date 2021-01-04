namespace Lr1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PDRs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PDRDTPs",
                c => new
                    {
                        PDR_Id = c.Int(nullable: false),
                        DTP_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PDR_Id, t.DTP_Id })
                .ForeignKey("dbo.PDRs", t => t.PDR_Id, cascadeDelete: true)
                .ForeignKey("dbo.DTPs", t => t.DTP_Id, cascadeDelete: true)
                .Index(t => t.PDR_Id)
                .Index(t => t.DTP_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PDRDTPs", "DTP_Id", "dbo.DTPs");
            DropForeignKey("dbo.PDRDTPs", "PDR_Id", "dbo.PDRs");
            DropIndex("dbo.PDRDTPs", new[] { "DTP_Id" });
            DropIndex("dbo.PDRDTPs", new[] { "PDR_Id" });
            DropTable("dbo.PDRDTPs");
            DropTable("dbo.PDRs");
        }
    }
}
