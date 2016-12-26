namespace Working.Infstructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
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
            
            CreateTable(
                "dbo.EmployeProjects",
                c => new
                    {
                        Project_ProjectId = c.Int(nullable: false),
                        Employe_EmployeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Project_ProjectId, t.Employe_EmployeId })
                .ForeignKey("dbo.Projects", t => t.Project_ProjectId, cascadeDelete: true)
                .ForeignKey("dbo.Employes", t => t.Employe_EmployeId, cascadeDelete: true)
                .Index(t => t.Project_ProjectId)
                .Index(t => t.Employe_EmployeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeProjects", "Employe_EmployeId", "dbo.Employes");
            DropForeignKey("dbo.EmployeProjects", "Project_ProjectId", "dbo.Projects");
            DropIndex("dbo.EmployeProjects", new[] { "Employe_EmployeId" });
            DropIndex("dbo.EmployeProjects", new[] { "Project_ProjectId" });
            DropTable("dbo.EmployeProjects");
            DropTable("dbo.Projects");
            DropTable("dbo.Employes");
        }
    }
}
