namespace EF_Code_First_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class headcolumnremoved : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Departments", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Departments", "DepartmentHead");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departments", "DepartmentHead", c => c.String());
            AlterColumn("dbo.Departments", "Name", c => c.String());
        }
    }
}
