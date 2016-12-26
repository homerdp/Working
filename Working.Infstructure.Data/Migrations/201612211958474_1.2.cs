namespace Working.Infstructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _12 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.EmployeProjects");
            AddColumn("dbo.EmployeProjects", "EmployeProjectId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.EmployeProjects", "EmployeProjectId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.EmployeProjects");
            DropColumn("dbo.EmployeProjects", "EmployeProjectId");
            AddPrimaryKey("dbo.EmployeProjects", new[] { "EmployeId", "ProjectId" });
        }
    }
}
