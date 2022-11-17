namespace EF_Code_First_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deptHeadcolumnadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "DepartmentHead", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Departments", "DepartmentHead");
        }
    }
}
