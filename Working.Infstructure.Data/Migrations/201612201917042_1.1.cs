namespace Working.Infstructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _11 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeProjects",
                c => new
                    {
                        EmployeId = c.Int(nullable: false),
                        ProjectId = c.Int(nullable: false),
                        DateStart = c.DateTime(nullable: false, storeType: "date"),
                        DateEnd = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => new { t.EmployeId, t.ProjectId })
                .ForeignKey("dbo.Employes", t => t.EmployeId, cascadeDelete: true)
                .ForeignKey("dbo.Projects", t => t.ProjectId, cascadeDelete: true)
                .Index(t => t.EmployeId)
                .Index(t => t.ProjectId);
            
            CreateTable(
                "dbo.Employes",
                c => new
                    {
                        EmployeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.EmployeId);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ProjectId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeProjects", "ProjectId", "dbo.Projects");
            DropForeignKey("dbo.EmployeProjects", "EmployeId", "dbo.Employes");
            DropIndex("dbo.EmployeProjects", new[] { "ProjectId" });
            DropIndex("dbo.EmployeProjects", new[] { "EmployeId" });
            DropTable("dbo.Projects");
            DropTable("dbo.Employes");
            DropTable("dbo.EmployeProjects");
        }
    }
}
