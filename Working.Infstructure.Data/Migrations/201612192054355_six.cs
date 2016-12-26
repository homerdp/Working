namespace Working.Infstructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class six : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.EmployeProjects", name: "Employe_EmployeId", newName: "EmployeId");
            AddColumn("dbo.EmployeProjects", "DateStart", c=>c.DateTime());
            AddColumn("dbo.EmployeProjects", "DateEnd", c => c.DateTime());
        }
        
        public override void Down()
        {
        }
    }
}
