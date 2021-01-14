namespace Lr1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DTPs", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.DTPs", "Type", c => c.String(nullable: false));
            AlterColumn("dbo.PDRs", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Shtrafs", "Person", c => c.String(nullable: false));
            AlterColumn("dbo.Shtrafs", "Address", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Shtrafs", "Address", c => c.String());
            AlterColumn("dbo.Shtrafs", "Person", c => c.String());
            AlterColumn("dbo.PDRs", "Name", c => c.String());
            AlterColumn("dbo.DTPs", "Type", c => c.String());
            AlterColumn("dbo.DTPs", "Name", c => c.String());
        }
    }
}
