namespace ThucHanh_Bai3_02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsCanceledColumnToCourse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "IsCaceled", c => c.Boolean(nullable: false));
            DropColumn("dbo.Courses", "IsCanceled");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "IsCanceled", c => c.Boolean(nullable: false));
            DropColumn("dbo.Courses", "IsCaceled");
        }
    }
}
