namespace employeeManagementApp.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabaseCreationWithEmployees : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        employeeId = c.Int(nullable: false, identity: true),
                        firstName = c.String(),
                        middleName = c.String(),
                        lastName = c.String(),
                        birthDate = c.DateTime(nullable: false),
                        hireDate = c.DateTime(nullable: false),
                        department = c.String(),
                        jobTitle = c.String(),
                        salary = c.Int(nullable: false),
                        availableHours = c.String(),
                    })
                .PrimaryKey(t => t.employeeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
