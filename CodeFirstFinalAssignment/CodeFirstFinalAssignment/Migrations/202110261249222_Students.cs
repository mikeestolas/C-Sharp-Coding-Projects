namespace CodeFirstFinalAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Students : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Dob = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.StudID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
