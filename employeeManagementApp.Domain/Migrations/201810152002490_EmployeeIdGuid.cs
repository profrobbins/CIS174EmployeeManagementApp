namespace employeeManagementApp.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeIdGuid : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Employees");
            AlterColumn("dbo.Employees", "employeeId", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Employees", "employeeId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Employees");
            AlterColumn("dbo.Employees", "employeeId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Employees", "employeeId");
        }
    }
}
