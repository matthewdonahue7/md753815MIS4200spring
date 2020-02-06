namespace md753815MIS4200spring.Migration.MISContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class custom : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VisitDetails", "petId", c => c.Int(nullable: false));
            DropColumn("dbo.VisitDetails", "description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VisitDetails", "description", c => c.String());
            DropColumn("dbo.VisitDetails", "petId");
        }
    }
}
