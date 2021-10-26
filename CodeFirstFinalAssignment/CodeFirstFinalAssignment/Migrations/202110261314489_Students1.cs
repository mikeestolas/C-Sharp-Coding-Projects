namespace CodeFirstFinalAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Students1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "ImageUrl", c => c.String(maxLength: 255));
            AlterColumn("dbo.Students", "Name", c => c.String(maxLength: 255));
            AlterColumn("dbo.Students", "Email", c => c.String(maxLength: 255));
            AlterColumn("dbo.Students", "Dob", c => c.String(maxLength: 255));
            AlterColumn("dbo.Students", "Address", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Address", c => c.String());
            AlterColumn("dbo.Students", "Dob", c => c.String());
            AlterColumn("dbo.Students", "Email", c => c.String());
            AlterColumn("dbo.Students", "Name", c => c.String());
            DropColumn("dbo.Students", "ImageUrl");
        }
    }
}
